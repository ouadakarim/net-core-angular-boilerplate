using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        // GET api/ping
        [HttpGet]
        [Produces("application/json")]
        public JsonResult Get()
        {
            var details = new Dictionary<string, string>
            {
                { "host", $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}"},
                { "status", "200" },
                { "value", "Pong" },
            };
            return new JsonResult(details);
        }
    }
}
