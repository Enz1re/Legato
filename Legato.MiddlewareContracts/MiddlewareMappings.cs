using AutoMapper;
using Legato.DAL.Models;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.MiddlewareContracts
{
    public static class MiddlewareMappings
    {
        private static IMapper _mapper;

        public static void CreateMappings()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GuitarModel, GuitarDataModel>()
                    .Include<AcousticClassicalGuitarModel, AcousticClassicalGuitarDataModel>()
                    .Include<AcousticWesternGuitarModel, AcousticWesternGuitarDataModel>()
                    .Include<ElectricGuitarModel, ElectricGuitarDataModel>()
                    .Include<BassGuitarModel, BassGuitarDataModel>();
                cfg.CreateMap<AcousticClassicalGuitarModel, AcousticClassicalGuitarDataModel>()
                    .ForMember(dest => dest.Vendor, opt => opt.MapFrom(src => src.Vendor.Name));
                cfg.CreateMap<AcousticWesternGuitarModel, AcousticWesternGuitarDataModel>()
                    .ForMember(dest => dest.Vendor, opt => opt.MapFrom(src => src.Vendor.Name));
                cfg.CreateMap<ElectricGuitarModel, ElectricGuitarDataModel>()
                    .ForMember(dest => dest.Vendor, opt => opt.MapFrom(src => src.Vendor.Name));
                cfg.CreateMap<BassGuitarModel, BassGuitarDataModel>()
                    .ForMember(dest => dest.Vendor, opt => opt.MapFrom(src => src.Vendor.Name));
            });

            _mapper = mapperConfiguration.CreateMapper();
        }

        public static TDestination Map<TDestination>(object sourceData)
        {
            return (TDestination)_mapper.Map(sourceData, sourceData.GetType(), typeof(TDestination));
        }
    }
}
