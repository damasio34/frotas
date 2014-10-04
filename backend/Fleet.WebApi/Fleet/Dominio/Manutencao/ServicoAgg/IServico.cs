namespace Kereta.Dominio.Manutencao.ServicoAgg
{
    public interface IServico
    {
        string Instrucoes { get; set; }
        int QuantidadeAntecipacao { get; set; }
        TipoDeFrequencia TipoDeFrequencia { get; set; }
    }
}