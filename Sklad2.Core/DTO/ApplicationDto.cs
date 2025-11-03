using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad2.Core.DTO
{
    public class ApplicationDto
    {

        public int Id { get; set; }


        public DateTime? Created { get; set; }


        public UserDto? User { get; set; }


        public List<ApplicationItemsDto>? Items { get; set; } = new List<ApplicationItemsDto>();



        //public int SupplierId { get; set; }


        //public SupplierDto? Supplier { get; set; }


        
    }
}
