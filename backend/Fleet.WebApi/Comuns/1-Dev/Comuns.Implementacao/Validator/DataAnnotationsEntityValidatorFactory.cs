using Vvs.Infraestrutura.Comuns.Validator;

namespace Vvs.Infraestrutura.Comuns.Implementacao.Validator
{
    public class DataAnnotationsEntityValidatorFactory
        :IEntityValidatorFactory
    {
        public IEntityValidator Create()
        {
            return new DataAnnotationsEntityValidator();
        }
    }
}
