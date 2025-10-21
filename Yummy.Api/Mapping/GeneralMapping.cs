using AutoMapper;
using Yummy.Api.DTO.FeatureDTO;
using Yummy.Api.DTO.MessageDTO;
using Yummy.Api.DTO.ProductDTO;
using Yummy.Api.Entity;

namespace Yummy.Api.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature, ResultFeatureDTO>().ReverseMap();
            CreateMap<Feature, CreateFeatureDTO>().ReverseMap();
            CreateMap<Feature, GetByIDFeatureDTO>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDTO>().ReverseMap();

            //*****************************************************************************************************//

            CreateMap<Message, UpdateMessageDTO>().ReverseMap();
            CreateMap<Message, CreateMessageDTO>().ReverseMap();
            CreateMap<Message, GetByIDMessageDTO>().ReverseMap();
            CreateMap<Message, ResultMessageDTO>().ReverseMap();

            //******************************************************************************************************//
            CreateMap<Product, CreateProductDTO>().ReverseMap();
            CreateMap<Product, ResultProductWithCategoryDTO>().ReverseMap().ForMember(x => x.Name, y => y.MapFrom(z => z.CategoryName)).ReverseMap();



        }
    }
}
