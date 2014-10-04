using System;

namespace Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear
{
    public class Hectometro : Comprimento
    {
        public Hectometro(Decimal valor)
            :base(valor,"hm")
        {
            
        }

        public Hectometro(Comprimento comprimentoOrigem)
            : base(comprimentoOrigem, "hm")
        {
            
        }


        #region [ Casts ]

        public static implicit operator Quilometro(Hectometro kilometro)
        {
            return new Quilometro(kilometro);
        }

        public static implicit operator Decametro(Hectometro kilometro)
        {
            return new Decametro(kilometro);
        }

        public static implicit operator Metro(Hectometro kilometro)
        {
            return new Metro(kilometro);
        }

        public static implicit operator Decimetro(Hectometro kilometro)
        {
            return new Decimetro(kilometro);
        }

        public static implicit operator Centimetro(Hectometro kilometro)
        {
            return new Centimetro(kilometro);
        }

        public static implicit operator Milimetro(Hectometro kilometro)
        {
            return new Milimetro(kilometro);
        }

        #endregion
    }
}
