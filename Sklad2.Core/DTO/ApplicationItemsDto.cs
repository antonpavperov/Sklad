using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad2.Core.DTO
{
    public class ApplicationItemsDto
    {
        public int Id { get; set; }

        
        public int? Quantity { get; set; }


        public int? Number {  get; set; }


        public int ApplicationId { get; set; }


        public ApplicationDto? Application { get; set; }

        
        public ScrapTypeDto? ScrapType { get; set; }


        public SupplierDto? Suppliers { get; set; }        
        
        
        public WareHouseDto? WareHouse { get; set; } 
        
        
        public WareHouseSectionDto? WareHouseItem { get; set; }
    }
}
