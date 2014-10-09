using System.Linq;
using Vvs.Domain.Seedwork.Aplicacao;

namespace Kereta.Web.Api
{
    public class PageableResponse : VoidResponse, IResponse<IQueryable>
    {
        public PageableResponse() { }
        public PageableResponse(params Mensagem[] mensagens) : base(mensagens) { }
        public PageableResponse(IQueryable value, long totalCount)
        {
            Value = value;
            Metadata = new Metadata
            {
                TotalCount = totalCount
            };
        }

        public PageableResponse(IQueryable value, long totalCount, Mensagem[] mensagens)
            : base(mensagens)
        {
            Value = value;
            Metadata = new Metadata
            {
                TotalCount = totalCount
            };
        }

        public IQueryable Value { get; private set; }
        public bool HasValue { get; private set; }
        public Metadata Metadata { get; private set; }
    }

}