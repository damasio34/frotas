using System;

namespace Kereta.Web.Api.Dto
{
    public class DataTransferObject
    {
        public DataTransferObject()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
