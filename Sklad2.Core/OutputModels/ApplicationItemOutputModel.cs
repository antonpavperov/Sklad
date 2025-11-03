using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad2.Core.OutputModels
{
    internal class ApplicationItemOutputModel
    {
        public int? Id { get; set; }


        public int? Number { get; set; } 


        public int? Quantity { get; set; }


        public string? ScrapTypeName { get; set; }
    }
}
