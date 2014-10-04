using System.Collections.Generic;
using System.Linq;

namespace Kereta.Web.Api.Configurations
{
    public enum TipoMensagem
    {
        Erro = 1,
        Alerta = 2,
        Sucesso = 3,
        Info = 4
    }
    public class Mensagem
    {
        public Mensagem(TipoMensagem tipo, string texto)
        {
            TipoMensagem = tipo;
            Texto = texto;
        }
        public string Texto { get; set; }
        public TipoMensagem TipoMensagem { get; set; }
    }

    public class AppResponse<Dto> : AppResponse
        where Dto : class
    {
        public AppResponse(Dto value, params Mensagem[] mensagens)
            : base(mensagens)
        {
            this.Value = value;
        }

        public Dto Value { get; private set; }
    }

    public class AppResponse
    {
        public AppResponse(params Mensagem[] mensagens)
        {
            Mensagens = mensagens.AsEnumerable();
        }

        public IEnumerable<Mensagem> Mensagens { get; private set; }

        public bool HasOk
        {
            get
            {
                return !HasErro;
            }
        }

        public bool HasSucesso
        {
            get
            {
                return Mensagens.Any(a => a.TipoMensagem == TipoMensagem.Sucesso);
            }
        }

        public bool HasAlerta
        {
            get
            {
                return Mensagens.Any(a => a.TipoMensagem == TipoMensagem.Alerta);
            }
        }
        public bool HasInfo
        {
            get
            {
                return Mensagens.Any(a => a.TipoMensagem == TipoMensagem.Info);
            }
        }

        public bool HasErro
        {
            get
            {
                return Mensagens.Any(a => a.TipoMensagem == TipoMensagem.Erro);
            }
        }

        public static AppResponse Ok(string mensagem)
        {
            var mensagens = new Mensagem[1] { new Mensagem(TipoMensagem.Sucesso, mensagem) };
            return new AppResponse(mensagens);
        }

        public static AppResponse Ok<Dto>(Dto value, string mensagem)
            where Dto : class
        {
            var mensagens = new Mensagem[1] { new Mensagem(TipoMensagem.Sucesso, mensagem) };
            return new AppResponse<Dto>(value, mensagens);
        }

        public static AppResponse Erro(string mensagem)
        {
            var mensagens = new Mensagem[1] { new Mensagem(TipoMensagem.Erro, mensagem) };
            return new AppResponse(mensagens);
        }

        public static AppResponse Erro<Dto>(string mensagem)
            where Dto : class
        {
            var mensagens = new Mensagem[1] { new Mensagem(TipoMensagem.Erro, mensagem) };
            return new AppResponse<Dto>(null, mensagens);
        }


    }


}
