using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklad2.Core.DTO;

namespace Sklad2.Core.IReposytories
{
    public interface ISupplierRepository
    {
        List<SupplierDto> GetAll();
    }
}
