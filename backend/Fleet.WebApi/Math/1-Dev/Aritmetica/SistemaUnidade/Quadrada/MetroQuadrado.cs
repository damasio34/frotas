using System;

namespace Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Quadrada
{
    public class MetroQuadrado : Area
    {
        public MetroQuadrado(Decimal valor)
            : base(valor, "m")
        {

        }


        public MetroQuadrado(Area comprimentoOrigem)
            : base(comprimentoOrigem, "m")
        {
            
        }

      
    }
}
