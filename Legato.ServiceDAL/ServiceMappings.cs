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
                cfg.CreateMap<GuitarDataModel, GuitarViewModel>()
                    .Include<AcousticClassicalGuitarDataModel, AcousticClassicalGuitarViewModel>()
                    .Include<AcousticWesternGuitarDataModel, AcousticWesternGuitarViewModel>()
                    .Include<ElectricGuitarDataModel, ElectricGuitarViewModel>()
                    .Include<BassGuitarDataModel, BassGuitarViewModel>();
                cfg.CreateMap<AcousticClassicalGuitarDataModel, AcousticClassicalGuitarViewModel>();
                cfg.CreateMap<AcousticWesternGuitarDataModel, AcousticWesternGuitarViewModel>();
                cfg.CreateMap<ElectricGuitarDataModel, ElectricGuitarViewModel>();
                cfg.CreateMap<BassGuitarDataModel, BassGuitarViewModel>();
            });

            _mapper = mapperConfiguration.CreateMapper();
        }

        public static TDestination Map<TDestination>(object sourceData)
        {
            return (TDestination)_mapper.Map(sourceData, sourceData.GetType(), typeof(TDestination));
        }
    }
}
