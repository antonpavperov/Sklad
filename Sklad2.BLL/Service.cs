using Mapster;
using Sklad2.Core.IReposytories;
using Sklad2.Core.OutputModels;

namespace Sklad2.BLL
{
    public class Service
    {
        private IApplicationRepository _applicationRepository;

        public Service(IApplicationRepository productRepository)
        {
            _applicationRepository = productRepository;
        }

        public List<ApplicationOutputModel> GetAll()
        {
            var tmp = _applicationRepository.GetAll();
            var result = tmp.Adapt<List<ApplicationOutputModel>>();
            return result;
        
        }
    }
}
