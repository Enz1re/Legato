﻿using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Middleware;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class AcousticWesternGuitarRepository : IGuitarRepository<AcousticWesternGuitarDataModel>
    {
        private LegatoMiddlewareClient _client;

        [Inject]
        public AcousticWesternGuitarRepository(LegatoMiddlewareClient client)
        {
            _client = client;
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAll(int lowerBound, int upperBound)
        {
            return _client.GetAllAcousticWesternGuitars(lowerBound, upperBound);
        }

        public IEnumerable<string> GetVendors()
        {
            return _client.GetAcousticWesternGuitarVendors();
        }

        public int GetAmount()
        {
            return _client.GetAcousticWesternGuitarQuantity();
        }

        public IEnumerable<AcousticWesternGuitarDataModel> FindByCost(int from, int to, int lowerBound, int upperBound)
        {
            return _client.GetAcousticWesternGuitarsByPrice(from, to, lowerBound, upperBound);
        }

        public IEnumerable<AcousticWesternGuitarDataModel> FindByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            return _client.GetAcousticWesternGuitarsByVendors(vendors, lowerBound, upperBound);
        }
    }
}
