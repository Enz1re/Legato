﻿using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.Middleware;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class ElectricGuitarRepository : IGuitarRepository<ElectricGuitarDataModel>
    {
        private LegatoMiddlewareClient _client;

        [Inject]
        public ElectricGuitarRepository(LegatoMiddlewareClient client)
        {
            _client = client;
        }

        public IEnumerable<ElectricGuitarDataModel> Get(FilterDataModel filter, int lowerBound, int upperBound)
        {
            return _client.GetElectricGuitars(filter, lowerBound, upperBound);
        }

        public IEnumerable<string> GetVendors()
        {
            return _client.GetElectricGuitarVendors();
        }
        
        public int GetAmount()
        {
            return _client.GetElectricGuitarQuantity();
        }
    }
}
