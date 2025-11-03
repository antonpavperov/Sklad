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
            config.Default.PreserveReference(true);


            config.NewConfig<ApplicationDto, ApplicationOutputModel>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Created, src => src.Created ?? DateTime.MinValue)
                .Map(dest => dest.SupplierName, src => src.Items != null && src.Items.Any() ? src.Items.First().Supplier.Name : null);


            config.NewConfig<ApplicationItemsDto, ApplicationItemOutputModel>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Number, src => src.Number)
                .Map(dest => dest.Quantity, src => src.Quantity)
                .Map(dest => dest.ScrapTypeName, src => src.ScrapType != null ? src.ScrapType.Name : "Не указан");
        }

    } 
}
