using System;

namespace Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear
{
    public class Metro : Comprimento
    {
        public Metro(Decimal valor)
            : base(valor, "m")
        {

        }

     
        public Metro(Comprimento comprimentoOrigem)
            : base(comprimentoOrigem, "m")
        {
            
        }

        #region [ Casts ]
    
        public static implicit operator Quilometro(Metro kilometro)
        {
            return new Quilometro(kilometro);
        }

        public static implicit operator Hectometro(Metro kilometro)
        {
            return new Hectometro(kilometro);
        }

        public static implicit operator Decametro(Metro kilometro)
        {
            return new Decametro(kilometro);
        }

        public static implicit operator Centimetro(Metro kilometro)
        {
            return new Centimetro(kilometro);
        }

        public static implicit operator Decimetro(Metro kilometro)
        {
            return new Decimetro(kilometro);
        }

        public static implicit operator Milimetro(Metro kilometro)
        {
            return new Milimetro(kilometro);
        }

        #endregion
    }
}
