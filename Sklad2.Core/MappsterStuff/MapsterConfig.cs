using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using Sklad2.Core.DTO;
using Sklad2.Core.OutputModels;

namespace Sklad2.Core.MappsterStuff
{
    public class MapsterConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.Default.PreserveReference(true);


            config.NewConfig<ApplicationDto, ApplicationOutputModel>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Created, src => src.Created ?? DateTime.Now)
                .Map(dest => dest.SupplierName, src => src.Items != null && src.Items.Any() ? src.Items.First().Supplier.Name : null)
                .Map(dest => dest.Items, src => src.Items != null
                    ? src.Items.Adapt<List<ApplicationItemOutputModel>>()
                    : new List<ApplicationItemOutputModel>());

            config.NewConfig<ApplicationItemsDto, ApplicationItemOutputModel>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Number, src => src.Number)
                .Map(dest => dest.Quantity, src => src.Quantity)
                .Map(dest => dest.ScrapTypeName, src => src.ScrapType != null ? src.ScrapType.Name : "Не указан");


            config.NewConfig<SupplierDto, SupplierOutputModel>();


            config.NewConfig<ScrapTypeDto, ScrapTypeOutputModel>()
                .Map(dest => dest.CategoryName, src => src.Category != null ? src.Category.Name : string.Empty);


            config.NewConfig<ApplicationOutputModel, ApplicationDto>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Items, src => src.Items != null
                    ? src.Items.Adapt<List<ApplicationItemsDto>>()
                    : new List<ApplicationItemsDto>());


            config.NewConfig<ApplicationItemOutputModel, ApplicationItemsDto>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Number, src => src.Number)
                .Map(dest => dest.Quantity, src => src.Quantity)
                .Map(dest => dest.SupplierId, src => src.SupplierId)
                .Map(dest => dest.ScrapTypeId, src => src.ScrapTypeId);

        }

    } 
}
