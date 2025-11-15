using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad2.Core.OutputModels
{
    public class ScrapTypeOutputModel
    {
        public int Id { get; set; }


        public string Name { get; set; } = string.Empty;


        public decimal Cost { get; set; }


        public string CategoryName { get; set; } = string.Empty;
    }
}
