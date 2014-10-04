//===================================================================================


using System;
using System.Linq;
using AutoMapper;
using Vvs.Infraestrutura.Comuns.Adapter;

namespace Vvs.Infraestrutura.Comuns.Implementacao.Adapter
{
    public class AutomapperTypeAdapter
        :ITypeAdapter
    {
        public AutomapperTypeAdapter()
        {
            Configure();
        }

        public void Configure()
        {

            var profiles = AppDomain.CurrentDomain
                                    .GetAssemblies()
                                    .SelectMany(a => a.GetTypes())
                                    .Where(t => t.BaseType == typeof(Profile));

            Mapper.Initialize(cfg =>
            {
                foreach (var item in profiles)
                {
                    if (item.FullName != "AutoMapper.SelfProfiler`2")
                        cfg.AddProfile(Activator.CreateInstance(item) as Profile);
                }
            });

        }

        #region ITypeAdapter Members

        public TTarget Adapt<TSource, TTarget>(TSource source)
            where TSource : class
            where TTarget : class
        {
            return Mapper.Map<TSource, TTarget>(source);
        }

        public TTarget Adapt<TTarget>(object source) where TTarget : class
        {
            return Mapper.Map<TTarget>(source);
        }

        #endregion
    }
}
