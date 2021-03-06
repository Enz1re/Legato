﻿using Ninject;
using System.Web.Http;
using Newtonsoft.Json;
using Legato.Service.Filters;
using Legato.Service.Interfaces;
using Legato.ServiceDAL.ViewModels;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.Service.Controllers
{
    [RoutePrefix("api/Classical")]
    public class ClassicalController : ApiController
    {
        private ILegatoGuitarServiceWorker _serviceWorker;

        [Inject]
        public ClassicalController(ILegatoGuitarServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        [GuitarFilter]
        [Route("{lowerBound}/{upperBound}")]
        public IHttpActionResult Get([FromUri]string filterJson, int lowerBound, int upperBound)
        {
            var filter = JsonConvert.DeserializeObject<FilterViewModel>(filterJson, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include
            });
            
            return Ok(_serviceWorker.GetAcousticClassicalGuitars(filter, lowerBound, upperBound));
        }

        [GuitarFilter]
        [Route("{lowerBound}/{upperBound}/{sortHeader}/{sortDirection}")]
        public IHttpActionResult GetSorted([FromUri]string filterJson, int lowerBound, int upperBound, string sortHeader, string sortDirection)
        {
            var filter = JsonConvert.DeserializeObject<FilterViewModel>(filterJson, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include
            });

            var sorting = new SortingViewModel
            {
                SortHeader = (SortHeader)System.Enum.Parse(typeof(SortHeader), sortHeader),
                SortDirection = (SortDirection)System.Enum.Parse(typeof(SortDirection), sortDirection)
            };
            
            return Ok(_serviceWorker.GetSortedAcousticClassicalGuitars(filter, lowerBound, upperBound, sorting));
        }

        [Route("Vendors")]
        public IHttpActionResult GetVendors()
        {
            return Ok(_serviceWorker.GetAcousticClassicalGuitarVendors());
        }

        [GuitarFilter]
        [Route("Quantity")]
        public IHttpActionResult GetQuantity([FromUri]string filterJson)
        {
            var filter = JsonConvert.DeserializeObject<FilterViewModel>(filterJson, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include
            });

            return Ok(_serviceWorker.GetAcousticClassicalGuitarAmount(filter));
        }
    }
}