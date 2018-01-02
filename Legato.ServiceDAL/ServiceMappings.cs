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
                cfg.AllowNullCollections = true;
                cfg.AllowNullDestinationValues = true;

                cfg.CreateMap<GuitarDataModel, GuitarViewModel>()
                    .Include<AcousticClassicalGuitarDataModel, AcousticClassicalGuitarViewModel>()
                    .Include<AcousticWesternGuitarDataModel, AcousticWesternGuitarViewModel>()
                    .Include<ElectricGuitarDataModel, ElectricGuitarViewModel>()
                    .Include<BassGuitarDataModel, BassGuitarViewModel>();

                cfg.CreateMap<VendorDataModel, VendorViewModel>()
                    .ForMember(dest => dest.IsSelected, opt => opt.MapFrom(src => true));
                cfg.CreateMap<VendorViewModel, VendorDataModel>();

                cfg.CreateMap<AcousticClassicalGuitarDataModel, AcousticClassicalGuitarViewModel>();
                cfg.CreateMap<AcousticWesternGuitarDataModel, AcousticWesternGuitarViewModel>();
                cfg.CreateMap<ElectricGuitarDataModel, ElectricGuitarViewModel>();
                cfg.CreateMap<BassGuitarDataModel, BassGuitarViewModel>();

                cfg.CreateMap<AcousticClassicalGuitarViewModel, AcousticClassicalGuitarDataModel>();
                cfg.CreateMap<AcousticWesternGuitarViewModel, AcousticWesternGuitarDataModel>();
                cfg.CreateMap<ElectricGuitarViewModel, ElectricGuitarDataModel>();
                cfg.CreateMap<BassGuitarViewModel, BassGuitarDataModel>();

                cfg.CreateMap<PriceFilterViewModel, PriceFilterDataModel>();
                cfg.CreateMap<VendorFilterViewModel, VendorFilterDataModel>();
                cfg.CreateMap<FilterViewModel, FilterDataModel>();
                cfg.CreateMap<SortingViewModel, SortingDataModel>();

                cfg.CreateMap<UserDataModel, UserViewModel>()
                    .ForMember(dist => dist.Name, opt => opt.MapFrom(src => src.Username))
                    .ForMember(dist => dist.Role, opt => opt.MapFrom(src => src.UserRole));

                cfg.CreateMap<CompromisedAttemptViewModel, CompromisedAttemptDataModel>();
                cfg.CreateMap<CompromisedAttemptDataModel, CompromisedAttemptViewModel>();

                cfg.CreateMap<ClaimsDataModel, ClaimsViewModel>();
            });

            _mapper = mapperConfiguration.CreateMapper();
        }

        public static TDestination Map<TDestination>(object sourceData)
        {
            return (TDestination)_mapper.Map(sourceData, sourceData.GetType(), typeof(TDestination));
        }
    }
}
