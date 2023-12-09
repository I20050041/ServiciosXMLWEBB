using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace service1.Controllers
{
    public class DatosController : ApiController
    {
        [HttpGet]
        public IHttpActionResult ObtenerDatosEnXML()
        {
            // Puedes construir un XML manualmente o utilizar clases y serialización XML
            // Aquí, un ejemplo simple
            string xmlData = "<datos><nombre>John Doe</nombre><edad>25</edad></datos>";
            return Ok(xmlData);
        }
    }
}
