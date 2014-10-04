using System;

namespace Vvs.Infraestrutura.Security.Authentication.CPlusAnywhere
{
    public static class Autenticador
    {

        public static bool Autenticar(IVvsCredentials credenciais)
        {
            if (credenciais == null) throw new ArgumentNullException("credenciais");

            // Autentica utilizando wsAutenticador
            // ToDo: Injetar lógica de autenticação, dependendo do ambiente (dev|beta|prod);
            var wsAutenticador = new ServiceProxy.wsAutenticador();
            var retorno = wsAutenticador.Autentica(
                credenciais.IdGrupoEmpresa,
                credenciais.LoginUsuario,
                credenciais.Senha);

            return retorno;
        }
    }
}
