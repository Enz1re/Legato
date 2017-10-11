using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using Legato.ServiceDAL.ViewModels;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL
{
    public static class ServiceMappings
    {
        public static void CreateMappings()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<GuitarDataModel, GuitarViewModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<AcousticClassicalGuitarDataModel, AcousticClassicalGuitarViewModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<AcousticWesternGuitarDataModel, AcousticWesternGuitarViewModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<ElectroGuitarDataModel, ElectroGuitarViewModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<BassGuitarDataModel, BassGuitarViewModel>());

            Mapper.Initialize(cfg => cfg.CreateMap<IEnumerable<GuitarDataModel>, IEnumerable<GuitarViewModel>>()
                .ConvertUsing(source => source.Select(Mapper.Map<GuitarDataModel, GuitarViewModel>)));
            Mapper.Initialize(cfg => cfg.CreateMap<IEnumerable<AcousticClassicalGuitarDataModel>, IEnumerable<AcousticClassicalGuitarViewModel>>()
                .ConvertUsing(source => source.Select(Mapper.Map<AcousticClassicalGuitarDataModel, AcousticClassicalGuitarViewModel>)));
            Mapper.Initialize(cfg => cfg.CreateMap<IEnumerable<AcousticWesternGuitarDataModel>, IEnumerable<AcousticWesternGuitarViewModel>>()
                .ConvertUsing(source => source.Select(Mapper.Map<AcousticWesternGuitarDataModel, AcousticWesternGuitarViewModel>)));
            Mapper.Initialize(cfg => cfg.CreateMap<IEnumerable<ElectroGuitarDataModel>, IEnumerable<ElectroGuitarViewModel>>()
                .ConvertUsing(source => source.Select(Mapper.Map<ElectroGuitarDataModel, ElectroGuitarViewModel>)));
            Mapper.Initialize(cfg => cfg.CreateMap<IEnumerable<BassGuitarDataModel>, IEnumerable<BassGuitarViewModel>>()
                .ConvertUsing(source => source.Select(Mapper.Map<BassGuitarDataModel, BassGuitarViewModel>)));
        }

        public static TDestination Map<TSource, TDestination>(TSource sourceData)
        {
            return Mapper.Map<TSource, TDestination>(sourceData);
        }
    }
}
