using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad2.Core.DTO
{
    public class ScrapTypeCategoryDto
    {
        public int Id { get; set; }


        public string Name { get; set; }


        public List<ScrapTypeDto> Items { get; set; } = new List<ScrapTypeDto>();
    }
}
