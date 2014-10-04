using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vvs.Domain.Seedwork;

namespace Vvs.Infraestrutura.Comuns.Tests.Stub
{
    public class EntidadeValidavelStub : EntityBase, IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield return new ValidationResult("Invalido");
        }
    }
}
