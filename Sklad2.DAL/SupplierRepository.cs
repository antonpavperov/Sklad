using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklad2.Core.DTO;
using Sklad2.Core.IReposytories;
using Sklad2.Core;

namespace Sklad2.DAL
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly DataContext _dataContext;

        public SupplierRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<SupplierDto> GetAll()
        {
            var result = _dataContext.Suppliers
                .OrderBy(s => s.Id)
                .Select(s => new SupplierDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Region = s.Region
                })
                .ToList();
            return result;
        }
    }
}
