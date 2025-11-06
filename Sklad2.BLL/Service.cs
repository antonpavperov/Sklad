using Mapster;
using Sklad2.Core.DTO;
using Sklad2.Core.IReposytories;
using Sklad2.Core.OutputModels;
using static System.Net.Mime.MediaTypeNames;

namespace Sklad2.BLL
{
    public class Service
    {
        private IApplicationRepository _applicationRepository;
        private IScrapTypeRepository _scrapTypeRepository;
        private ISupplierRepository _supplierRepository;

        public Service(
            IApplicationRepository applicationRepository,
            IScrapTypeRepository scrapTypeRepository,
            ISupplierRepository supplierRepository)
        {
            _applicationRepository = applicationRepository;
            _scrapTypeRepository = scrapTypeRepository;
            _supplierRepository = supplierRepository;
        }

        public List<ApplicationOutputModel> GetAll()
        {
            var tmp = _applicationRepository.GetAll();
            var result = tmp.Adapt<List<ApplicationOutputModel>>();
            return result;
        }


        public List<SupplierDto> GetSuppliers()
        {
            return _supplierRepository.GetAll();
        }


        public List<ScrapTypeDto> GetScrapTypes()
        {
            return _scrapTypeRepository.GetAll();
        }


        public ApplicationOutputModel AddApplication(ApplicationOutputModel application)
        {
            if (application.Items == null)
            {
                application.Items = new List<ApplicationItemOutputModel>();
            }


            if (application.Created == default)
            {
                application.Created = DateTime.UtcNow;
            }


            var dto = application.Adapt<ApplicationDto>();



            if (dto.Items != null)
            {
                foreach (var item in dto.Items)
                {
                    item.SupplierId = application.SupplierId; 
                }
            }


            var added = _applicationRepository.Add(dto);


            return added.Adapt<ApplicationOutputModel>();
        }


        public void DeleteApplication(int id)
        {
            _applicationRepository.Delete(id);
        }



    }
}
