using AutoMapper;
using Legato.ServiceDAL.ViewModels;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL
{
    public static class ServiceMappings
    {
        private static IMapper _mapper;

        public static void CreateMappings()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GuitarDataModel, GuitarViewModel>();
                cfg.CreateMap<AcousticClassicalGuitarDataModel, AcousticClassicalGuitarViewModel>();
                cfg.CreateMap<AcousticWesternGuitarDataModel, AcousticWesternGuitarViewModel>();
                cfg.CreateMap<ElectroGuitarDataModel, ElectroGuitarViewModel>();
                cfg.CreateMap<BassGuitarDataModel, BassGuitarViewModel>();
            });

            _mapper = mapperConfiguration.CreateMapper();
        }

        public static TDestination Map<TDestination>(object sourceData)
        {
            return _mapper.Map<TDestination>(sourceData);
        }
    }
}
