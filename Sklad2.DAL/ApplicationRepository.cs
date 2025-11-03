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

        public ApplicationDto Add(ApplicationDto application)
        {
            _dataContext.Add(application);
            _dataContext.SaveChanges();

            return application;
        }

        public List<ApplicationDto> GetAll()
        {
            var result = _dataContext.Application
                .OrderBy(a => a.Id).ToList();
                
            return result;
        }

    }
}
