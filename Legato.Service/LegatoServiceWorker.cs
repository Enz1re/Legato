using Legato.ServiceDAL;
using Legato.Service.ReturnTypes;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.ViewModels;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.Service
{
    public class LegatoServiceWorker : ILegatoServiceWorker
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

        public VendorList GetAcousticClassicalGuitarVendors()
        {
            return new VendorList
            {
                Vendors = ServiceMappings.Map<List<string>>
                (
                    _unitOfWork.ClassicAcousticGuitars.GetVendors()
                )
            };
        }

        public Amount GetAcousticClassicalGuitarAmount()
        {
            return new Amount
            {
                Quantity = _unitOfWork.ClassicAcousticGuitars.GetAmount()
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

        public VendorList GetAcousticWesternGuitarVendors()
        {
            return new VendorList
            {
                Vendors = ServiceMappings.Map<List<string>>
                (
                    _unitOfWork.WesternAcousticGuitars.GetVendors()
                )
            };
        }

        public Amount GetAcousticWesternGuitarAmount()
        {
            return new Amount
            {
                Quantity = _unitOfWork.WesternAcousticGuitars.GetAmount()
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

        public VendorList GetElectricGuitarVendors()
        {
            return new VendorList
            {
                Vendors = ServiceMappings.Map<List<string>>
                (
                    _unitOfWork.ElectricGuitars.GetVendors()
                )
            };
        }

        public Amount GetElectricGuitarAmount()
        {
            return new Amount
            {
                Quantity = _unitOfWork.ElectricGuitars.GetAmount()
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

        public VendorList GetBassGuitarVendors()
        {
            return new VendorList
            {
                Vendors = ServiceMappings.Map<List<string>>
                (
                    _unitOfWork.BassGuitars.GetVendors()
                )
            };
        }

        public Amount GetBassGuitarAmount()
        {
            return new Amount
            {
                Quantity = _unitOfWork.BassGuitars.GetAmount()
            };
        }
    }
}