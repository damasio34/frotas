using System;

namespace Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear
{
    public class Centimetro: Comprimento
    {
        public Centimetro(Decimal valor)
            : base(valor, "cm")
        {

        }


        public Centimetro(Comprimento comprimentoOrigem)
            : base(comprimentoOrigem, "cm")
        {
            
        }

        public static implicit operator Milimetro(Centimetro centimetro)
        {
            return new Milimetro(centimetro);
        }

        public static explicit operator Centimetro(Milimetro milimetro)
        {
            return new Centimetro(milimetro);
        }

        public static explicit operator Decametro(Centimetro centimetro)
        {
            return new Decametro(centimetro);
        }

        public static explicit operator Hectometro(Centimetro centimetro)
        {
            return new Hectometro(centimetro);
        }
    }
}
