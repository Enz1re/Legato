﻿using System.Collections.Generic;
using Legato.ServiceDAL.ViewModels;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Interfaces
{
    public interface IGuitarRepository<TGuitar> where TGuitar: GuitarDataModel
    {
        IEnumerable<TGuitar> GetAll();

        IEnumerable<VendorViewModel> GetVendors();

        IEnumerable<TGuitar> FindByVendor(string vendor);

        IEnumerable<TGuitar> FindByCost(short from, short to);
    }
}
