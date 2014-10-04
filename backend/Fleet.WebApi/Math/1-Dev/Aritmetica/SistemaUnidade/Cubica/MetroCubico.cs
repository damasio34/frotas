using System;

namespace Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Cubica
{
    public class MetroCubico : Volume
    {
        public MetroCubico(Decimal valor)
            : base(valor, "m")
        {

        }


        public MetroCubico(Volume comprimentoOrigem)
            : base(comprimentoOrigem,"m")
        {
            
        }


        public override TipoUnidadeMedida Tipo
        {
            get
            {
                if (this is MetroCubico)
                    return TipoUnidadeMedida.Metro;

                throw new InvalidCastException();
            }
        }

      
    }
}
