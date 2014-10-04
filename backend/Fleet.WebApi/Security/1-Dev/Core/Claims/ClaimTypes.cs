
namespace Vvs.Infraestrutura.Security.Claims
{
    public static class ClaimTypes
    {

        public static class GrupoEmpresa
        {
            public const string Id = "http://schemas.vvssistemas.com.br/ws/identity/claims/grupoEmpresa/id";
            public const string RazaoSocial = "http://schemas.vvssistemas.com.br/ws/identity/claims/grupoEmpresa/razaoSocial";
            public const string Cnpj = "http://schemas.vvssistemas.com.br/ws/identity/claims/grupoEmpresa/cnpj";
            public const string Serial = "http://schemas.vvssistemas.com.br/ws/identity/claims/grupoEmpresa/serial";
        }

        public static class Usuario
        {
            public const string Id = "http://schemas.vvssistemas.com.br/ws/identity/claims/usuario/id";
            public const string Login = "http://schemas.vvssistemas.com.br/ws/identity/claims/usuario/login";
            public const string Nome = "http://schemas.vvssistemas.com.br/ws/identity/claims/usuario/nome";
        }

        public static class Licenciamento
        {
            public const string QtdMaximaDeUsuarios = "http://schemas.vvssistemas.com.br/ws/identity/claims/Licenciamento/QtdMaximaDeUsuarios";
            public const string QtdUsuariosCadastrados = "http://schemas.vvssistemas.com.br/ws/identity/claims/Licenciamento/QtdUsuariosCadastrados";
            public const string QtdMaximaDeEmpresas = "http://schemas.vvssistemas.com.br/ws/identity/claims/Licenciamento/QtdMaximaDeEmpresas";
            public const string QtdEmpresasCadastradas = "http://schemas.vvssistemas.com.br/ws/identity/claims/Licenciamento/QtdMaximaDeUsuarios";
        }
        
    }
}
