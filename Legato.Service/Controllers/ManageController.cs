using System;
using Ninject;
using System.Web.Http;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Controllers
{
    [RoutePrefix("api/Manage")]
    public class ManageController : ApiController
    {
        private ILegatoManageServiceWorker _serviceWorker;

        [Inject]
        public ManageController(ILegatoManageServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        [HttpPost]
        [Route("{type}/Add")]
        public IHttpActionResult Add([FromBody] string guitarJson, string type)
        {
            var guitar = Serialization.Deserialize<AcousticClassicalGuitarViewModel>(guitarJson);
            var parsedType = (GuitarType)Enum.Parse(typeof(GuitarType), type);

            if (guitar != null)
            {
                try
                {
                    _serviceWorker.Add(guitar, parsedType);
                    return Ok();
                }
                catch (Exception e)
                {
                    return InternalServerError(e);
                }
            }
            else
            {
                return BadRequest(Constants.Strings.GuitarIsInvalid);
            }
        }

        [HttpPost]
        [Route("{type}/Edit")]
        public IHttpActionResult Edit([FromBody] string guitarJson, string type)
        {
            var guitar = Serialization.Deserialize<AcousticClassicalGuitarViewModel>(guitarJson);
            var parsedType = (GuitarType)Enum.Parse(typeof(GuitarType), type);

            if (guitar != null)
            {
                try
                {
                    _serviceWorker.Edit(guitar, parsedType);
                    return Ok();
                }
                catch (Exception e)
                {
                    return InternalServerError(e);
                }
            }
            else
            {
                return BadRequest(Constants.Strings.GuitarIsInvalid);
            }
        }

        [Route("{type}/{id}")]
        public IHttpActionResult Delete(string type, int id)
        {
            var parsedType = (GuitarType)Enum.Parse(typeof(GuitarType), type);

            try
            {
                _serviceWorker.Remove(id, parsedType);
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
