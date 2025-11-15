using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklad2.Core.DTO;
using Sklad2.Core.IReposytories;
using Sklad2.Core;
using Microsoft.EntityFrameworkCore;

namespace Sklad2.DAL
{
    public class WareHouseRepository : IWareHouseRepository
    {
        private readonly DataContext _datacontext;

        public WareHouseRepository(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public List<WareHouseDto> GetAll()
        {
            return _datacontext.WareHouses
                .Include(w => w.Secnions)
                .ToList();
        }
    }

}
