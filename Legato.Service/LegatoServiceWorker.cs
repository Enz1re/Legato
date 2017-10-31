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
            return new VendorList { Vendors = ServiceMappings.Map<List<VendorViewModel>>(_unitOfWork.ClassicAcousticGuitars.GetVendors()) };
        }

        public GuitarList GetAcousticClassicalGuitarsByPrice(short from, short to)
        {
            return new GuitarList { Guitars = ServiceMappings.Map<List<AcousticClassicalGuitarViewModel>>(_unitOfWork.ClassicAcousticGuitars.FindByCost(from, to)) };
        }

        public VendorList GetAcousticWesternGuitarVendors()
        {
            return new VendorList { Vendors = ServiceMappings.Map<List<VendorViewModel>>(_unitOfWork.WesternAcousticGuitars.GetVendors()) };
        }

        public GuitarList GetAcousticWesternGuitarsByPrice(short from, short to)
        {
            return new GuitarList { Guitars = ServiceMappings.Map<List<AcousticWesternGuitarViewModel>>(_unitOfWork.WesternAcousticGuitars.FindByCost(from, to)) };
        }

        public GuitarList GetBassGuitarsByPrice(short from, short to)
        {
            return new GuitarList { Guitars = ServiceMappings.Map<List<BassGuitarViewModel>>(_unitOfWork.BassGuitars.FindByCost(from, to)) };
        }

        public VendorList GetElectricGuitarVendors()
        {
            return new VendorList { Vendors = ServiceMappings.Map<List<VendorViewModel>>(_unitOfWork.ElectricGuitars.GetVendors()) };
        }

        public GuitarList GetElectricGuitarsByPrice(short from, short to)
        {
            return new GuitarList { Guitars = ServiceMappings.Map<List<ElectricGuitarViewModel>>(_unitOfWork.ElectricGuitars.FindByCost(from, to)) };
        }

        public GuitarList GetAllAcousticClassicalGuitars()
        {
            return new GuitarList { Guitars = ServiceMappings.Map<List<AcousticClassicalGuitarViewModel>>(_unitOfWork.ClassicAcousticGuitars.GetAll()) };
        }

        public GuitarList GetAllAcousticWesternGuitars()
        {
            return new GuitarList { Guitars = ServiceMappings.Map<List<AcousticWesternGuitarViewModel>>(_unitOfWork.WesternAcousticGuitars.GetAll()) };
        }

        public VendorList GetBassGuitarVendors()
        {
            return new VendorList { Vendors = ServiceMappings.Map<List<VendorViewModel>>(_unitOfWork.BassGuitars.GetVendors()) };
        }

        public GuitarList GetAllElectricGuitars()
        {
            return new GuitarList { Guitars = ServiceMappings.Map<List<ElectricGuitarViewModel>>(_unitOfWork.ElectricGuitars.GetAll()) };
        }

        public GuitarList GetAllBassGuitars()
        {
            return new GuitarList { Guitars = ServiceMappings.Map<List<BassGuitarViewModel>>(_unitOfWork.BassGuitars.GetAll()) };
        }

        public GuitarList GetAcousticClassicalGuitarsByVendor(string vendor)
        {
            return new GuitarList { Guitars = ServiceMappings.Map<List<AcousticClassicalGuitarViewModel>>(_unitOfWork.ClassicAcousticGuitars.FindByVendor(vendor)) };
        }

        public GuitarList GetAcousticWesternGuitarsByVendor(string vendor)
        {
            return new GuitarList { Guitars = ServiceMappings.Map<List<AcousticWesternGuitarViewModel>>(_unitOfWork.WesternAcousticGuitars.FindByVendor(vendor)) };
        }

        public GuitarList GetElectricGuitarsByVendor(string vendor)
        {
            return new GuitarList { Guitars = ServiceMappings.Map<List<ElectricGuitarViewModel>>(_unitOfWork.ElectricGuitars.FindByVendor(vendor)) };
        }

        public GuitarList GetBassGuitarsByVendor(string vendor)
        {
            return new GuitarList { Guitars = ServiceMappings.Map<List<BassGuitarViewModel>>(_unitOfWork.BassGuitars.FindByVendor(vendor)) };
        }
    }
}