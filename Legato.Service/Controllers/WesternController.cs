﻿using System.Web.Http;
using System.Collections.Generic;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Controllers
{
    public class WesternController : ApiController
    {
        private ILegatoServiceWorker _serviceWorker;

        public WesternController(ILegatoServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        public IEnumerable<AcousticWesternGuitarViewModel> Get()
        {
            return _serviceWorker.GetAllAcousticWesternGuitars();
        }

        public IEnumerable<AcousticWesternGuitarViewModel> Get(string vendor)
        {
            return _serviceWorker.GetAcousticWesternGuitarsByVendor(vendor);
        }

        public IEnumerable<AcousticWesternGuitarViewModel> Get(short from, short to)
        {
            return _serviceWorker.GetAcousticWesternGuitarsByPrice(from, to);
        }
    }
}