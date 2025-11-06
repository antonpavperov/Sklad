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
                .Include(a => a.Items)
                    .ThenInclude(i => i.ScrapType)
                .Include(a => a.Items)
                    .ThenInclude(i =>i.Supplier)
                .OrderBy(a => a.Id).ToList();
                
            return result;
        }


        public void Delete(int id)
        {
            var entity = _dataContext.Application
                .Include(a => a.Items)
                .FirstOrDefault(a => a.Id == id);

            if (entity != null)
            {
                _dataContext.ApplicationItems.RemoveRange(entity.Items);
                _dataContext.Application.Remove(entity);
                _dataContext.SaveChanges();
            }
        }


    }
}
