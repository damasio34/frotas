

namespace Vvs.Infraestrutura.Comuns.Validator
{
    public interface IEntityValidatorFactory
    {
        IEntityValidator Create();
    }
}
