using Microsoft.EntityFrameworkCore;
using Sklad2.Core;
using Sklad2.Core.DTO;
using Sklad2.Core.IReposytories;

namespace Sklad2.DAL
{
    public class ScrapTypeRepository : IScrapTypeRepository
    {
        private readonly DataContext _dataContext;

        public ScrapTypeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<ScrapTypeDto> GetAll()
        {
            var result = _dataContext.ScrapTypes
                .OrderBy(s => s.Id)
                .Select(s => new ScrapTypeDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Cost = s.Cost,
                    CategoryId = s.CategoryId
                })
                .ToList();
            return result;
        }
    }
}