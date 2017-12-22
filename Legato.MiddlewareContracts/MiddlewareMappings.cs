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

                cfg.CreateMap<VendorModel, VendorDataModel>();
                cfg.CreateMap<VendorDataModel, VendorModel>();

                cfg.CreateMap<AcousticClassicalGuitarModel, AcousticClassicalGuitarDataModel>();
                cfg.CreateMap<AcousticWesternGuitarModel, AcousticWesternGuitarDataModel>();
                cfg.CreateMap<ElectricGuitarModel, ElectricGuitarDataModel>();
                cfg.CreateMap<BassGuitarModel, BassGuitarDataModel>();

                cfg.CreateMap<AcousticClassicalGuitarDataModel, AcousticClassicalGuitarModel>();
                cfg.CreateMap<AcousticWesternGuitarDataModel, AcousticWesternGuitarModel>();
                cfg.CreateMap<ElectricGuitarDataModel, ElectricGuitarModel>();
                cfg.CreateMap<BassGuitarDataModel, BassGuitarModel>();

                cfg.CreateMap<UserModel, UserDataModel>()
                    .ForMember(dest => dest.UserRole, opt => opt.MapFrom(src => src.UserRole.RoleName));
            });

            _mapper = mapperConfiguration.CreateMapper();
        }

        public static TDestination Map<TDestination>(object sourceData)
        {
            return (TDestination)_mapper.Map(sourceData, sourceData.GetType(), typeof(TDestination));
        }
    }
}
