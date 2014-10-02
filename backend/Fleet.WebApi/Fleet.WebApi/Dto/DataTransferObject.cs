using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fleet.WebApi.Dto
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
