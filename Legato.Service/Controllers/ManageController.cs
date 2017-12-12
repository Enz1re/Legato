using System;
using Ninject;
using System.IO;
using Newtonsoft.Json;
using System.Web.Http;
using System.Threading;
using System.Collections.Generic;
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
            // Capitalize type to be able to parse its enumeration value
            type = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(type);
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
            // Capitalize type to be able to parse its enumeration value
            type = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(type);
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
            // Capitalize type to be able to parse its enumeration value
            type = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(type);
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

        [HttpGet]
        [Route("Display")]
        public IHttpActionResult GetDisplayAmount()
        {
            try
            {
                var root = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText($@"{AppDomain.CurrentDomain.BaseDirectory}/settings.json"));
                return Ok(new { displayAmount = Convert.ToInt32(root["displayAmount"]) });
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost]
        [Route("Display/{amount}")]
        public IHttpActionResult PostDisplayAmount(int amount)
        {
            try
            {
                var root = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText($@"{AppDomain.CurrentDomain.BaseDirectory}/settings.json"));
                root["displayAmount"] = amount.ToString();
                File.WriteAllText($@"{AppDomain.CurrentDomain.BaseDirectory}/settings.json", JsonConvert.SerializeObject(root, Formatting.Indented));
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
