using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarRegisterWebAPI.Controllers
{
    [Authorize]
    public class ClientsController : ApiController
    {

        [HttpGet]
        [Route("api/GetClients")]
        public IHttpActionResult GetAllClients()
        {

            return Ok();
        }
    }
}
