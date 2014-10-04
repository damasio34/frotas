using System;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Cubica;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Quadrada;

namespace Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade
{
    public abstract class UnidadeMedida
    {
        protected UnidadeMedida(Comprimento comprimentoOrigem, string sigla)
        {
            Sigla = sigla;
            FatorExponencial = 1;
            ConverterValor(comprimentoOrigem);
        }


        protected UnidadeMedida(Area areaOrigem, string sigla)
        {
            Sigla = sigla;
            FatorExponencial = 2;
            ConverterValor(areaOrigem);
        }

        protected UnidadeMedida(Volume areaOrigem, string sigla)
        {
            Sigla = sigla;
            FatorExponencial = 3;
            ConverterValor(areaOrigem);
        }

        protected UnidadeMedida(Decimal valorOrigem, string sigla, int fator)
        {
            Sigla = sigla;
            FatorExponencial = fator;
            Valor = valorOrigem;
        }

        protected int FatorExponencial { get; set; }

        private void ConverterValor(UnidadeMedida comprimentoOrigem)
        {
            decimal valorOrigem = comprimentoOrigem.Valor * (comprimentoOrigem.DistanciaPotencial * FatorExponencial);

            this.Valor = valorOrigem / (DistanciaPotencial * FatorExponencial);
        }

        public decimal DistanciaPotencial
        {
            get
            {
                return (decimal)DezElevadoAPotencia((int)Tipo);
            }
        }

        public abstract TipoUnidadeMedida Tipo { get; }

        public Decimal Valor { get; set; }

        protected Decimal DezElevadoAPotencia(int potencia)
        {
            return (Decimal)System.Math.Pow(10, potencia);
        }

        public virtual String ValorFormatado
        {
            get
            {
                //TODO: usar string format
                return Valor.ToString() + ' ' + Sigla + GetCharExpoente();
            }
        }

        private string GetCharExpoente()
        {
            switch (FatorExponencial)
            {
                case 1:
                    return string.Empty;
                case 2:
                    return "²";
                case 3:
                    return "³";
            }

            throw new InvalidCastException("FatorExponencial só pode ser 1,2 ou 3");
        }

        public String Sigla;
    }
}
