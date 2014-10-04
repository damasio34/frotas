using System;

namespace Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear
{
    public class Decametro : Comprimento
    {
        public Decametro(Decimal valor)
            : base(valor, "dam")
        {

        }

        public Decametro(Comprimento comprimentoOrigem)
            : base(comprimentoOrigem, "dam")
        {
            
        }

        #region [ Casts ]

        public static implicit operator Quilometro(Decametro kilometro)
        {
            return new Quilometro(kilometro);
        }

        public static implicit operator Hectometro(Decametro kilometro)
        {
            return new Hectometro(kilometro);
        }

        public static implicit operator Metro(Decametro kilometro)
        {
            return new Metro(kilometro);
        }

        public static implicit operator Decimetro(Decametro kilometro)
        {
            return new Decimetro(kilometro);
        }

        public static implicit operator Centimetro(Decametro kilometro)
        {
            return new Centimetro(kilometro);
        }

        public static implicit operator Milimetro(Decametro kilometro)
        {
            return new Milimetro(kilometro);
        }

        #endregion

    }
}
