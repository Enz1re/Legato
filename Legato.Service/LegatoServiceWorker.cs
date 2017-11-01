using Legato.ServiceDAL;
using Legato.Service.ReturnTypes;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service
{
    public class LegatoServiceWorker : ILegatoServiceWorker
    {
        private IGuitarUnitOfWork _unitOfWork;

        public LegatoServiceWorker(IGuitarUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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

        public GuitarList GetAcousticClassicalGuitarsByPrice(int from, int to, int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<AcousticClassicalGuitarViewModel>>
                (
                    _unitOfWork.ClassicAcousticGuitars.FindByCost(from, to, lowerBound, upperBound)
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

        public GuitarList GetAcousticWesternGuitarsByPrice(int from, int to, int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<AcousticWesternGuitarViewModel>>
                (
                    _unitOfWork.WesternAcousticGuitars.FindByCost(from, to, lowerBound, upperBound)
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

        public GuitarList GetBassGuitarsByPrice(int from, int to, int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<BassGuitarViewModel>>
                (
                    _unitOfWork.BassGuitars.FindByCost(from, to, lowerBound, upperBound)
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

        public GuitarList GetElectricGuitarsByPrice(int from, int to, int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<ElectricGuitarViewModel>>
                (
                    _unitOfWork.ElectricGuitars.FindByCost(from, to, lowerBound, upperBound)
                )
            };
        }

        public GuitarList GetAllAcousticClassicalGuitars(int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<AcousticClassicalGuitarViewModel>>
                (
                    _unitOfWork.ClassicAcousticGuitars.GetAll(lowerBound, upperBound)
                )
            };
        }

        public GuitarList GetAllAcousticWesternGuitars(int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<AcousticWesternGuitarViewModel>>
                (
                    _unitOfWork.WesternAcousticGuitars.GetAll(lowerBound, upperBound)
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

        public GuitarList GetAllElectricGuitars(int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<ElectricGuitarViewModel>>
                (
                    _unitOfWork.ElectricGuitars.GetAll(lowerBound, upperBound)
                )
            };
        }

        public GuitarList GetAllBassGuitars(int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<BassGuitarViewModel>>
                (
                    _unitOfWork.BassGuitars.GetAll(lowerBound, upperBound)
                )
            };
        }

        public GuitarList GetAcousticClassicalGuitarsByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<AcousticClassicalGuitarViewModel>>
                (
                    _unitOfWork.ClassicAcousticGuitars.FindByVendors(vendors, lowerBound, upperBound)
                )
            };
        }

        public GuitarList GetAcousticWesternGuitarsByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<AcousticWesternGuitarViewModel>>
                (
                    _unitOfWork.WesternAcousticGuitars.FindByVendors(vendors, lowerBound, upperBound)
                )
            };
        }

        public GuitarList GetElectricGuitarsByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<ElectricGuitarViewModel>>
                (
                    _unitOfWork.ElectricGuitars.FindByVendors(vendors, lowerBound, upperBound)
                )
            };
        }

        public GuitarList GetBassGuitarsByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            return new GuitarList
            {
                Guitars = ServiceMappings.Map<List<BassGuitarViewModel>>
                (
                    _unitOfWork.BassGuitars.FindByVendors(vendors, lowerBound, upperBound)
                )
            };
        }
    }
}