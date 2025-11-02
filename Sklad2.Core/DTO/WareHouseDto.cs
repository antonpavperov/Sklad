using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad2.Core.DTO
{
    public class WareHouseDto
    {
        public int Id { get; set; }


        public string? Name { get; set; }


        public List<WareHouseSectionDto> Secnions { get; set; } = new List<WareHouseSectionDto>();


        public List<ApplicationItemsDto>? ApplicationItems { get; set; }
    }
}
