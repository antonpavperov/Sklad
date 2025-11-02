using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad2.Core.DTO
{
    public class ScrapTypeDto
    {

        public int Id { get; set; }


        public string? Name { get; set; }


        public decimal? Cost { get; set; }


        public int? CategoryId { get; set; }


        public ScrapTypeCategoryDto? Category { get; set; }


        public List<ApplicationItemsDto>? Items { get; set; }
    }
}
