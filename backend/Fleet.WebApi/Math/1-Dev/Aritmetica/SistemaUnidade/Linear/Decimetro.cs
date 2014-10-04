using System;

namespace Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear
{
    public class Decimetro : Comprimento
    {
        public Decimetro(Decimal valor)
            : base(valor, "dm")
        {

        }

        public Decimetro(Comprimento comprimentoOrigem)
            : base(comprimentoOrigem, "dm")
        {
            
        }

        #region [ Casts ]

        public static implicit operator Quilometro(Decimetro kilometro)
        {
            return new Quilometro(kilometro);
        }

        public static implicit operator Hectometro(Decimetro kilometro)
        {
            return new Hectometro(kilometro);
        }

        public static implicit operator Decametro(Decimetro kilometro)
        {
            return new Decametro(kilometro);
        }

        public static implicit operator Metro(Decimetro kilometro)
        {
            return new Metro(kilometro);
        }

        public static implicit operator Centimetro(Decimetro kilometro)
        {
            return new Centimetro(kilometro);
        }

        public static implicit operator Milimetro(Decimetro kilometro)
        {
            return new Milimetro(kilometro);
        }

        #endregion
    }
}
