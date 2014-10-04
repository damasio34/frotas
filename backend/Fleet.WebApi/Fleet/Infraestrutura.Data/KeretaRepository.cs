using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Infraestrutura.Data.Unit;
using Vvs.Domain.Seedwork.Repositorios;
using Vvs.Domain.Seedwork.UnitOfWork;

namespace Kereta.Infraestrutura.Data
{
    public class KeretaRepository<T> : Repository<T>
        where T : class
    {
        public KeretaRepository(IKeretaUnitOfWork uow) : base(uow) { }

    }
}
