using AutoMapper;
using Homer.Applications.Dtos;
using HomerV2.Applications;

namespace HomerV2;

public class HomerV2ApplicationAutoMapperProfile : Profile
{
    public HomerV2ApplicationAutoMapperProfile()
    {

        CreateMap<Application, ApplicationDto>();
        CreateMap<ApplicationDto, Application>();

        CreateMap<ChangeApplicationNameDto, Application>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        CreateMap<ChangeApplicationLogoDto, Application>().ForMember(dest => dest.Logo, opt => opt.MapFrom(src => src.Logo));
        CreateMap<ChangeApplicationUrlDto, Application>().ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url));
        CreateMap<ChangeApplicationTargetDto, Application>().ForMember(dest => dest.Target, opt => opt.MapFrom(src => src.Target));
        CreateMap<UpdateApplicationMenuTypesDto, Application>().ForMember(dest => dest.MenuTypes, opt => opt.MapFrom(src => src.MenuTypes));
    }
}
