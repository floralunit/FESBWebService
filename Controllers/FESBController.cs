using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FESBWebService.Model;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO.Pipelines;
using Newtonsoft.Json.Linq;

namespace FESBWebService.Controllers
{
    [Route("fesb")]
    [ApiController]
    public class FESBController : ControllerBase
    {
        // GET: fesb/getPerson
        /// <summary>
        /// Заглушка GET
        /// </summary>
        [HttpGet("getPerson")]
        public async Task<ActionResult<RootObject>> GetPerson()
        {
            var additionalInfoExample = new AdditionalInfo() { Infoset = new Infoset()};
            var obj = new RootObject()
            {
                Info = new Info() { },
                Object = new {Person = new Person()},
                AdditionalInfo = new List<AdditionalInfo>() { additionalInfoExample }
            };
            return Ok(obj);
        }

        // POST: fesb/getPerson
        /// <summary>
        /// Заглушка POST
        /// </summary>
        [HttpPost("setPerson")]
        public async Task<ActionResult<RootObject>> SetPerson(RootObject obj)
        {
            if (obj.Object.GetType().GetMember("person") != null)
            {
                return Ok(obj);
            }
            else return BadRequest();
        }
    }
}