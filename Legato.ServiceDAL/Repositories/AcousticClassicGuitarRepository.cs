﻿using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Middleware;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class AcousticClassicalGuitarRepository : IGuitarRepository<AcousticClassicalGuitarDataModel>
    {
        private LegatoMiddlewareClient _client;

        [Inject]
        public AcousticClassicalGuitarRepository(LegatoMiddlewareClient client)
        {
            _client = client;
            _client.Open();
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAll()
        {
            return _client.GetAllAcousticClassicalGuitars();
        }

        public IEnumerable<string> GetVendors()
        {
            return _client.GetAcousticClassicalGuitarVendors();
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> FindByCost(short from, short to)
        {
            return _client.GetAcousticClassicalGuitarsByPrice(from, to);
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> FindByVendor(string vendor)
        {
            return _client.GetAcousticClassicalGuitarsByVendor(vendor);
        }

        public void Dispose()
        {
            _client.Close();
        }
    }
}
