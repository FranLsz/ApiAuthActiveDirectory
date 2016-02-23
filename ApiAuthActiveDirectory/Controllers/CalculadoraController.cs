using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiAuthActiveDirectory.Models;

namespace ApiAuthActiveDirectory.Controllers
{
    [Authorize]
    public class CalculadoraController : ApiController
    {
        [ResponseType(typeof(int))]
        [HttpPost]
        [Route("api/suma")]
        public IHttpActionResult Suma(Operacion op)
        {
            return Ok(op.Op1 + op.Op2);
        }

        [ResponseType(typeof(int))]
        [HttpPost]
        [Route("api/resta")]
        public IHttpActionResult Resta(Operacion op)
        {
            return Ok(op.Op1 - op.Op2);
        }

        [ResponseType(typeof(int))]
        [HttpPost]
        [Route("api/multiplicacion")]
        public IHttpActionResult Multiplicacion(Operacion op)
        {
            return Ok(op.Op1 * op.Op2);
        }

        [ResponseType(typeof(int))]
        [HttpPost]
        [Route("api/division")]
        public IHttpActionResult Division(Operacion op)
        {
            return Ok(op.Op1 / op.Op2);
        }
    }
}
