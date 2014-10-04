using System;

namespace Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear
{
    public class Quilometro : Comprimento
    {

        public Quilometro(Decimal valor)
            : base(valor,  "km")
        {
            
        }

        public Quilometro(Comprimento comprimentoOrigem)
            : base(comprimentoOrigem, "km")
        {
            
        }

        #region [ Casts ]

       

        public static implicit operator Hectometro(Quilometro kilometro)
        {
            return new Hectometro(kilometro);
        }

        public static implicit operator Decametro(Quilometro kilometro)
        {
            return new Decametro(kilometro);
        }

        public static implicit operator Metro(Quilometro kilometro)
        {
            return new Metro(kilometro);
        }

        public static implicit operator Decimetro(Quilometro kilometro)
        {
            return new Decimetro(kilometro);
        }

        public static implicit operator Centimetro(Quilometro kilometro)
        {
            return new Centimetro(kilometro);
        }

        public static implicit operator Milimetro(Quilometro kilometro)
        {
            return new Milimetro(kilometro);
        } 

        #endregion

    }
}
