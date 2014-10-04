
namespace Vvs.Infraestrutura.Security.Authentication
{
    public interface IVvsCredentials
    {
        int IdGrupoEmpresa { get; }
        string LoginUsuario { get; }
        string Senha { get; }
    }
}
