using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklad2.Core.DTO;

namespace Sklad2.Core.OutputModels
{
    public class ApplicationOutputModel
    {
        public int Id { get; set; }


        public DateTime Created { get; set; }


        public string UserName { get; set; }


        public List<ApplicationItemsDto> Items { get; set; } = new List<ApplicationItemsDto>();


        public string SupplierName { get; set; }
    }
}
