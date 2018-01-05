using System;
using Ninject;
using System.IO;
using Newtonsoft.Json;
using System.Web.Http;
using System.Threading;
using Legato.Service.Filters;
using Legato.Service.Constants;
using Legato.Service.Extensions;
using Legato.Service.Interfaces;
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
        [LegatoAuthentication]
        [LegatoAuthorize(Strings.AddGuitarClaim)]
        [ValidateAntiforgeryTokenPost]
        public IHttpActionResult Add([FromBody] dynamic guitarParam, string type)
        {
            // Capitalize type to be able to parse its enumeration value
            type = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(type);
            var guitar = Serialization.Deserialize<AcousticClassicalGuitarViewModel>(guitarParam.guitarJson.Value);
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
                return BadRequest(Strings.GuitarIsInvalid);
            }
        }

        [HttpPost]
        [Route("{type}/Edit")]
        [LegatoAuthentication]
        [LegatoAuthorize(Strings.EditGuitarClaim)]
        [ValidateAntiforgeryTokenPost]
        public IHttpActionResult Edit([FromBody] dynamic guitarParam, string type)
        {
            // Capitalize type to be able to parse its enumeration value
            type = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(type);
            var guitar = Serialization.Deserialize<AcousticClassicalGuitarViewModel>(guitarParam.guitarJson.Value);
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
                return BadRequest(Strings.GuitarIsInvalid);
            }
        }

        [Route("{type}/{id}")]
        [LegatoAuthentication]
        [LegatoAuthorize(Strings.RemoveGuitarClaim)]
        [ValidateAntiforgeryTokenDelete]
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
        [LegatoAuthentication]
        [LegatoAuthorize(Strings.ChangeDisplayAmounClaim)]
        [ValidateAntiforgeryTokenPost]
        public IHttpActionResult ChangeDisplayAmount(int amount)
        {
            if (10 > amount || amount > 100)
            {
                return BadRequest(Strings.DisplayAmountIsInvalid);
            }

            try
            {
                var root = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText($@"{AppDomain.CurrentDomain.BaseDirectory}/settings.json"));
                int displayAmountValue = Convert.ToInt32(root["displayAmount"]);

                if (displayAmountValue != amount)
                {
                    root["displayAmount"] = amount.ToString();
                    File.WriteAllText($@"{AppDomain.CurrentDomain.BaseDirectory}/settings.json", JsonConvert.SerializeObject(root, Formatting.Indented));
                    return Ok();
                }

                return this.NotModified();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpGet]
        [Route("Tokens")]
        public IHttpActionResult GetAntiforgeryTokens()
        {
            var root = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText($@"{AppDomain.CurrentDomain.BaseDirectory}/settings.json"));
            string antiforgeryTokenGet = root["antiforgeryTokenGet"];
            string antiforgeryTokenPost = root["antiforgeryTokenPost"];
            string antiforgeryTokenDelete = root["antiforgeryTokenDelete"];

            return Ok(new { AntiforgeryTokenGet = antiforgeryTokenGet,
                            AntiforgeryTokenPost = antiforgeryTokenPost,
                            AntiforgeryTokenDelete = antiforgeryTokenDelete });
        }
    }
}
