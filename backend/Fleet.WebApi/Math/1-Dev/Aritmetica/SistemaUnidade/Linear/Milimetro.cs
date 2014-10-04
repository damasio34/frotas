using System;

namespace Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear
{
    public class Milimetro : Comprimento
    {
        public Milimetro(Decimal valor)
            : base(valor, "mm")
        {

        }

        public Milimetro(Comprimento comprimentoOrigem)
            : base(comprimentoOrigem, "mm")
        {

        }

        #region [ Casts ]

        public static implicit operator Quilometro(Milimetro kilometro)
        {
            return new Quilometro(kilometro);
        }

        public static implicit operator Hectometro(Milimetro kilometro)
        {
            return new Hectometro(kilometro);
        }

        public static implicit operator Decametro(Milimetro kilometro)
        {
            return new Decametro(kilometro);
        }

        public static implicit operator Metro(Milimetro kilometro)
        {
            return new Metro(kilometro);
        }

        public static implicit operator Decimetro(Milimetro kilometro)
        {
            return new Decimetro(kilometro);
        }

        public static implicit operator Centimetro(Milimetro kilometro)
        {
            return new Centimetro(kilometro);
        }

       

        #endregion
    }
}
