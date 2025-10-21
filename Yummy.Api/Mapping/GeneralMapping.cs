using AutoMapper;
using Yummy.Api.DTO.FeatureDTO;
using Yummy.Api.DTO.MessageDTO;
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




        }
    }
}
