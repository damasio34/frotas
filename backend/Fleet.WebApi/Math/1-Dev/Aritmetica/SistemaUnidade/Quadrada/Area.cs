using System;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Cubica;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear;

namespace Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Quadrada
{

    /*
     -----------------------------------
     |  Km  |  m  |  dm  |  cm  |  mm  |
     -----------------------------------
     |  1   | 10³ |  10⁴ |  10⁵ |  10⁶ |
     -----------------------------------
     A multiplicação pela Potência é representada pelo método de nome DezElevadoAPotencia()
     */
    public abstract class Area : UnidadeMedida
    {
        protected Area(Decimal valor, string sigla)
            : base(valor, sigla, 2)
        {
        }

        protected Area(Area areaOrigem, string sigla)
            : base(areaOrigem, sigla)
        {

        }


        public static MetroCubico operator *(Area a, Comprimento b)
        {
            var _a = new MetroQuadrado(a);
            var _b = new Metro(b);
            return new MetroCubico(_a.Valor * _b.Valor);
        }

        public static Metro operator /(Area a, Comprimento b)
        {
            var _a = new MetroQuadrado(a);
            var _b = new Metro(b);
            return new Metro(_a.Valor / _b.Valor);
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


    }
}
