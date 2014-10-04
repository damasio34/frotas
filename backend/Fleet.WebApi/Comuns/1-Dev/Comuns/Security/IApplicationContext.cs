using System;

namespace Vvs.Infraestrutura.Comuns.Security
{
    public interface IApplicationContext
    {
        Guid IdUsuario { get; set; }
    }
}
