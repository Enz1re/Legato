﻿using Legato.ServiceDAL;
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

        public IEnumerable<GuitarViewModel> GetAllGuitars()
        {
            return ServiceMappings.Map<List<GuitarViewModel>>(_unitOfWork.GuitarsCommon.GetAll());
        }

        public IEnumerable<string> GetAllVendors()
        {
            return _unitOfWork.GuitarsCommon.GetVendors();
        }

        public IEnumerable<GuitarViewModel> GetGuitarsByPrice(short from, short to)
        {
            return ServiceMappings.Map<List<GuitarViewModel>>(_unitOfWork.GuitarsCommon.FindByCost(from, to));
        }

        public IEnumerable<GuitarViewModel> GetGuitarsByVendor(string vendor)
        {
            return ServiceMappings.Map<List<GuitarViewModel>>(_unitOfWork.GuitarsCommon.FindByVendor(vendor));
        }

        public IEnumerable<string> GetAcousticClassicalGuitarVendors()
        {
            return _unitOfWork.ClassicAcousticGuitars.GetVendors();
        }

        public IEnumerable<AcousticClassicalGuitarViewModel> GetAcousticClassicalGuitarsByPrice(short from, short to)
        {
            return ServiceMappings.Map<List<AcousticClassicalGuitarViewModel>>(_unitOfWork.ClassicAcousticGuitars.FindByCost(from, to));
        }

        public IEnumerable<string> GetAcousticWesternGuitarVendors()
        {
            return _unitOfWork.WesternAcousticGuitars.GetVendors();
        }

        public IEnumerable<AcousticWesternGuitarViewModel> GetAcousticWesternGuitarsByPrice(short from, short to)
        {
            return ServiceMappings.Map<List<AcousticWesternGuitarViewModel>>(_unitOfWork.WesternAcousticGuitars.FindByCost(from, to));
        }

        public IEnumerable<BassGuitarViewModel> GetBassGuitarsByPrice(short from, short to)
        {
            return ServiceMappings.Map<List<BassGuitarViewModel>>(_unitOfWork.BassGuitars.FindByCost(from, to));
        }

        public IEnumerable<string> GetElectricGuitarVendors()
        {
            return _unitOfWork.ElectricGuitars.GetVendors();
        }

        public IEnumerable<ElectroGuitarViewModel> GetElectroGuitarsByPrice(short from, short to)
        {
            return ServiceMappings.Map<List<ElectroGuitarViewModel>>(_unitOfWork.ElectricGuitars.FindByCost(from, to));
        }

        public IEnumerable<AcousticClassicalGuitarViewModel> GetAllAcousticClassicalGuitars()
        {
            return ServiceMappings.Map<List<AcousticClassicalGuitarViewModel>>(_unitOfWork.ClassicAcousticGuitars.GetAll());
        }

        public IEnumerable<AcousticWesternGuitarViewModel> GetAllAcousticWesternGuitars()
        {
            return ServiceMappings.Map<List<AcousticWesternGuitarViewModel>>(_unitOfWork.WesternAcousticGuitars.GetAll());
        }

        public IEnumerable<string> GetBassGuitarVendors()
        {
            return _unitOfWork.BassGuitars.GetVendors();
        }

        public IEnumerable<ElectroGuitarViewModel> GetAllElectroGuitars()
        {
            return ServiceMappings.Map<List<ElectroGuitarViewModel>>(_unitOfWork.ElectricGuitars.GetAll());
        }

        public IEnumerable<BassGuitarViewModel> GetAllBassGuitars()
        {
            return ServiceMappings.Map<List<BassGuitarViewModel>>(_unitOfWork.BassGuitars.GetAll());
        }

        public IEnumerable<AcousticClassicalGuitarViewModel> GetAcousticClassicalGuitarsByVendor(string vendor)
        {
            return ServiceMappings.Map<List<AcousticClassicalGuitarViewModel>>(_unitOfWork.ClassicAcousticGuitars.FindByVendor(vendor));
        }

        public IEnumerable<AcousticWesternGuitarViewModel> GetAcousticWesternGuitarsByVendor(string vendor)
        {
            return ServiceMappings.Map<List<AcousticWesternGuitarViewModel>>(_unitOfWork.WesternAcousticGuitars.FindByVendor(vendor));
        }

        public IEnumerable<ElectroGuitarViewModel> GetElectroGuitarsByVendor(string vendor)
        {
            return ServiceMappings.Map<List<ElectroGuitarViewModel>>(_unitOfWork.ElectricGuitars.FindByVendor(vendor));
        }

        public IEnumerable<BassGuitarViewModel> GetBassGuitarsByVendor(string vendor)
        {
            return ServiceMappings.Map<List<BassGuitarViewModel>>(_unitOfWork.BassGuitars.FindByVendor(vendor));
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}