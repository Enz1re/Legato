using Legato.ServiceDAL;
using Legato.Service.ReturnTypes;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.ViewModels;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.Service
{
    public class LegatoServiceWorker : ILegatoGuitarServiceWorker
    {
        private IGuitarUnitOfWork _unitOfWork;

        public LegatoServiceWorker(IGuitarUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public GuitarList GetAcousticClassicalGuitars(FilterViewModel filter, int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<AcousticClassicalGuitarViewModel>>
                (
                    _unitOfWork.ClassicAcousticGuitars.Get(ServiceMappings.Map<FilterDataModel>(filter), lowerBound, upperBound)
                )
            };
        }

        public GuitarList GetSortedAcousticClassicalGuitars(FilterViewModel filter, int lowerBound, int upperBound, SortingViewModel sorting)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<AcousticClassicalGuitarViewModel>>
                (
                    _unitOfWork.ClassicAcousticGuitars.GetSorted(ServiceMappings.Map<FilterDataModel>(filter),
                                                                 lowerBound,
                                                                 upperBound,
                                                                 ServiceMappings.Map<SortingDataModel>(sorting))
                )
            };
        }
        
        public VendorList GetAcousticClassicalGuitarVendors()
        {
            return new VendorList
            {
                Vendors = ServiceMappings.Map<List<VendorViewModel>>
                (
                    _unitOfWork.ClassicAcousticGuitars.GetVendors()
                )
            };
        }

        public Amount GetAcousticClassicalGuitarAmount(FilterViewModel filter)
        {
            return new Amount
            {
                Quantity = _unitOfWork.ClassicAcousticGuitars.GetAmount(ServiceMappings.Map<FilterDataModel>(filter))
            };
        }

        public GuitarList GetAcousticWesternGuitars(FilterViewModel filter, int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<AcousticWesternGuitarViewModel>>
                (
                    _unitOfWork.WesternAcousticGuitars.Get(ServiceMappings.Map<FilterDataModel>(filter), lowerBound, upperBound)
                )
            };
        }

        public GuitarList GetSortedAcousticWesternGuitars(FilterViewModel filter, int lowerBound, int upperBound, SortingViewModel sorting)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<AcousticWesternGuitarViewModel>>
                (
                    _unitOfWork.WesternAcousticGuitars.GetSorted(ServiceMappings.Map<FilterDataModel>(filter),
                                                                 lowerBound,
                                                                 upperBound,
                                                                 ServiceMappings.Map<SortingDataModel>(sorting))
                )
            };
        }
        
        public VendorList GetAcousticWesternGuitarVendors()
        {
            return new VendorList
            {
                Vendors = ServiceMappings.Map<List<VendorViewModel>>
                (
                    _unitOfWork.WesternAcousticGuitars.GetVendors()
                )
            };
        }

        public Amount GetAcousticWesternGuitarAmount(FilterViewModel filter)
        {
            return new Amount
            {
                Quantity = _unitOfWork.WesternAcousticGuitars.GetAmount(ServiceMappings.Map<FilterDataModel>(filter))
            };
        }

        public GuitarList GetElectricGuitars(FilterViewModel filter, int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<ElectricGuitarViewModel>>
                (
                    _unitOfWork.ElectricGuitars.Get(ServiceMappings.Map<FilterDataModel>(filter), lowerBound, upperBound)
                )
            };
        }

        public GuitarList GetSortedElectricGuitars(FilterViewModel filter, int lowerBound, int upperBound, SortingViewModel sorting)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<ElectricGuitarViewModel>>
                (
                    _unitOfWork.ElectricGuitars.GetSorted(ServiceMappings.Map<FilterDataModel>(filter),
                                                          lowerBound,
                                                          upperBound,
                                                          ServiceMappings.Map<SortingDataModel>(sorting))
                )
            };
        }
        
        public VendorList GetElectricGuitarVendors()
        {
            return new VendorList
            {
                Vendors = ServiceMappings.Map<List<VendorViewModel>>
                (
                    _unitOfWork.ElectricGuitars.GetVendors()
                )
            };
        }

        public Amount GetElectricGuitarAmount(FilterViewModel filter)
        {
            return new Amount
            {
                Quantity = _unitOfWork.ElectricGuitars.GetAmount(ServiceMappings.Map<FilterDataModel>(filter))
            };
        }

        public GuitarList GetBassGuitars(FilterViewModel filter, int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<BassGuitarViewModel>>
                (
                    _unitOfWork.BassGuitars.Get(ServiceMappings.Map<FilterDataModel>(filter), lowerBound, upperBound)
                )
            };
        }

        public GuitarList GetSortedBassGuitars(FilterViewModel filter, int lowerBound, int upperBound, SortingViewModel sorting)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<BassGuitarViewModel>>
                (
                    _unitOfWork.BassGuitars.GetSorted(ServiceMappings.Map<FilterDataModel>(filter),
                                                      lowerBound,
                                                      upperBound,
                                                      ServiceMappings.Map<SortingDataModel>(sorting))
                )
            };
        }
        
        public VendorList GetBassGuitarVendors()
        {
            return new VendorList
            {
                Vendors = ServiceMappings.Map<List<VendorViewModel>>
                (
                    _unitOfWork.BassGuitars.GetVendors()
                )
            };
        }

        public Amount GetBassGuitarAmount(FilterViewModel filter)
        {
            return new Amount
            {
                Quantity = _unitOfWork.BassGuitars.GetAmount(ServiceMappings.Map<FilterDataModel>(filter))
            };
        }
    }
}