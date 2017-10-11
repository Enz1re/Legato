using System;
using AutoMapper;
using System.Linq;
using Legato.DAL.Models;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceContracts
{
    public static class MiddlewareMappings
    {
        public static void CreateMappings()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<GuitarModel, GuitarDataModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<AcousticClassicalGuitarModel, AcousticClassicalGuitarDataModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<AcousticWesternGuitarModel, AcousticWesternGuitarDataModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<ElectroGuitarModel, ElectroGuitarDataModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<BassGuitarModel, BassGuitarDataModel>());

            Mapper.Initialize(cfg => cfg.CreateMap<IEnumerable<GuitarModel>, IEnumerable<GuitarDataModel>>()
                .ConvertUsing(source => source.Select(Mapper.Map<GuitarModel, GuitarDataModel>)));
            Mapper.Initialize(cfg => cfg.CreateMap<IEnumerable<AcousticClassicalGuitarModel>, IEnumerable<AcousticClassicalGuitarDataModel>>()
                .ConvertUsing(source => source.Select(Mapper.Map<AcousticClassicalGuitarModel, AcousticClassicalGuitarDataModel>)));
            Mapper.Initialize(cfg => cfg.CreateMap<IEnumerable<AcousticWesternGuitarModel>, IEnumerable<AcousticWesternGuitarDataModel>>()
                .ConvertUsing(source => source.Select(Mapper.Map<AcousticWesternGuitarModel, AcousticWesternGuitarDataModel>)));
            Mapper.Initialize(cfg => cfg.CreateMap<IEnumerable<ElectroGuitarModel>, IEnumerable<ElectroGuitarDataModel>>()
                .ConvertUsing(source => source.Select(Mapper.Map<ElectroGuitarModel, ElectroGuitarDataModel>)));
            Mapper.Initialize(cfg => cfg.CreateMap<IEnumerable<BassGuitarModel>, IEnumerable<BassGuitarDataModel>>()
                .ConvertUsing(source => source.Select(Mapper.Map<BassGuitarModel, BassGuitarDataModel>)));
        }

        public static TDestination Map<TSource, TDestination>(TSource sourceData)
        {
            try
            {
                return Mapper.Map<TSource, TDestination>(sourceData);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
