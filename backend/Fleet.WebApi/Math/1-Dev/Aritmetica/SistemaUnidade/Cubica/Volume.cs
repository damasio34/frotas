using System;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Quadrada;

namespace Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Cubica
{

    /*
     -----------------------------------
     |  Km  |  m  |  dm  |  cm  |  mm  |
     -----------------------------------
     |  1   | 10³ |  10⁴ |  10⁵ |  10⁶ |
     -----------------------------------
     A multiplicação pela Potência é representada pelo método de nome DezElevadoAPotencia()
     */
    public abstract class Volume : UnidadeMedida
    {
        protected Volume(Decimal valor, string sigla)
            : base(valor, sigla, 3)
        {
        }

        protected Volume(Volume areaOrigem, string sigla)
            : base(areaOrigem, sigla)
        {

        }


        public override TipoUnidadeMedida Tipo
        {
            get
            {
                if (this is MetroQuadrado)
                    return TipoUnidadeMedida.Metro;

                throw new InvalidCastException();
            }
        }

        public static MetroQuadrado operator /(Volume a, Comprimento b)
        {
            var _a = new MetroCubico(a);
            var _b = new Metro(b);
            return new MetroQuadrado(_a.Valor / _b.Valor);
        }


    }
}
