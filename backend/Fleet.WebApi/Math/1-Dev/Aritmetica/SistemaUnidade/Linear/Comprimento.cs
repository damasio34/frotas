using System;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Quadrada;

namespace Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear
{

    /*
     -----------------------------------
     |  Km  |  m  |  dm  |  cm  |  mm  |
     -----------------------------------
     |  1   | 10³ |  10⁴ |  10⁵ |  10⁶ |
     -----------------------------------
     A multiplicação pela Potência é representada pelo método de nome DezElevadoAPotencia()
     */
    public abstract class Comprimento : UnidadeMedida
    {
        protected Comprimento(Decimal valor, string sigla)
            : base(valor, sigla, 1)
        {

        }

        protected Comprimento(Comprimento comprimentoOrigem, string sigla)
            : base(comprimentoOrigem, sigla)
        {

        }

        public override TipoUnidadeMedida Tipo
        {
            get
            {
                if (this is Quilometro)
                    return TipoUnidadeMedida.Quilometro;

                if (this is Hectometro)
                    return TipoUnidadeMedida.Hectometro;

                if (this is Decametro)
                    return TipoUnidadeMedida.Decametro;

                if (this is Metro)
                    return TipoUnidadeMedida.Metro;

                if (this is Decimetro)
                    return TipoUnidadeMedida.Decimetro;

                if (this is Centimetro)
                    return TipoUnidadeMedida.Centimetro;

                if (this is Milimetro)
                    return TipoUnidadeMedida.Milimetro;

                throw new InvalidCastException();
            }
        }

        public static Metro operator +(Comprimento a, Comprimento b)
        {
            var _a = new Metro(a);
            var _b = new Metro(b);
            return new Metro(_a.Valor + _b.Valor);
        }

        public static Metro operator -(Comprimento a, Comprimento b)
        {
            var _a = new Metro(a);
            var _b = new Metro(b);
            return new Metro(_a.Valor - _b.Valor);
        }

        public static MetroQuadrado operator *(Comprimento a, Comprimento b)
        {
            var _a = new Metro(a);
            var _b = new Metro(b);
            return new MetroQuadrado(_a.Valor * _b.Valor);
        }



    }
}
