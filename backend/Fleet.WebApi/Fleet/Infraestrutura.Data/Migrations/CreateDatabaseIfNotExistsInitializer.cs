using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereta.Infraestrutura.Data.Migrations
{
    public class CreateDatabaseIfNotExistsInitializer : CreateDatabaseIfNotExists<KeretaUnitOfWork>
    {
        protected override void Seed(KeretaUnitOfWork unitOfWork)
        {
            new SeedDatabase().Seed(unitOfWork);
        }
    }
}
