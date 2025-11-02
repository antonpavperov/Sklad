using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad2.Core.DTO
{
    public class SupplierDto
    {
        public int Id { get; set; }


        public string? Name { get; set; }


        public string? Region { get; set; }


        public int? ApplicationItemsId { get; set; }


        public ApplicationItemsDto? ApplicationItems { get; set; }
    }
}
