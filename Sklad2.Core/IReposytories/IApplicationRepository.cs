using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklad2.Core.DTO;

namespace Sklad2.Core.IReposytories
{
    public interface IApplicationRepository
    {
        public List<ApplicationDto> GetAll();


        ApplicationDto Add(ApplicationDto application);


        void Delete(int id);

        void MoveItemToSection(int itemId, int wareHouseId, int wareHouseItemId);
    }


}
