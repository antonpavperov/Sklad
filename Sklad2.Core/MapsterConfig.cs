using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using Sklad2.Core.DTO;
using Sklad2.Core.OutputModels;

namespace Sklad2.Core
{
    public class MapsterConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {

            config.NewConfig<ApplicationDto, ApplicationOutputModel>()
            .Map(dest => dest.SupplierName, src => src.Supplier.Name)
            .Map(dest => dest.Created, src => src.Created)
            .Map(dest => dest.Items, src => src.Items)
            .Map(dest => dest.UserName, src => src.User != null ? src.User.Login : null);


            config.NewConfig<ApplicationItemsDto, ApplicationItemOutputModel>()
               .Map(dest => dest.ScrapTypeName, src => src.ScrapType != null ? src.ScrapType.Name : null);
        }

    } 
}
