using Ninject;
using Newtonsoft.Json;
using System.Web.Http;
using Legato.Service.Filters;
using Legato.ServiceDAL.ViewModels;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.Service.Controllers
{
    [RoutePrefix("api/Western")]
    public class WesternController : ApiController
    {
        private ILegatoServiceWorker _serviceWorker;

        [Inject]
        public WesternController(ILegatoServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        [JwtAuth]
        [GuitarFilter]
        [Route("{lowerBound}/{upperBound}")]
        public IHttpActionResult Get([FromUri]string filterJson, int lowerBound, int upperBound)
        {
            var filter = JsonConvert.DeserializeObject<FilterViewModel>(filterJson, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include
            });

            return Ok(_serviceWorker.GetAcousticWesternGuitars(filter, lowerBound, upperBound));
        }

        [JwtAuth]
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

            return Ok(_serviceWorker.GetSortedAcousticWesternGuitars(filter, lowerBound, upperBound, sorting));
        }

        [JwtAuth]
        [Route("Vendors")]
        public IHttpActionResult GetVendors()
        {
            return Ok(_serviceWorker.GetAcousticWesternGuitarVendors());
        }

        [JwtAuth]
        [GuitarFilter]
        [Route("Quantity")]
        public IHttpActionResult GetQuantity([FromUri]string filterJson)
        {
            var filter = JsonConvert.DeserializeObject<FilterViewModel>(filterJson, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include
            });

            return Ok(_serviceWorker.GetAcousticWesternGuitarAmount(filter));
        }
    }
}