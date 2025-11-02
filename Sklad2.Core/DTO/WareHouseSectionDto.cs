using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad2.Core.DTO
{
    public class WareHouseSectionDto
    {
        public int Id { get; set; }


        public string? Name { get; set; }


        public decimal? Quantity { get; set; }


        public int WareHouseId { get; set; }


        public WareHouseDto? WareHouse { get; set; }


        public List<ApplicationItemsDto>? ApplicationItems { get; set; }
    }
}
