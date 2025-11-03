using Microsoft.EntityFrameworkCore;
using Sklad2.Core;
using Sklad2.Core.DTO;
using Sklad2.Core.IReposytories;

namespace Sklad2.DAL
{
    public class ApplicationRepository : IApplicationRepository
    {
        private DataContext _dataContext;


        public ApplicationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;

        }

        public List<ApplicationDto> GetAll()
        {
            var result = _dataContext.Application
                .Include(a => a.Supplier)
                .Include(a => a.User)
                .Include(a => a.Items)          
                    .ThenInclude(i => i.ScrapType)
                .OrderBy(a => a.Id)
                .ToList();

            return result;
        }


    }
}
