using BLL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;


namespace APILicores.Controllers
{
    [RoutePrefix("API/Licores")]
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class ClienteController : ApiController
    {
        // GET: Cliente
       
            [HttpGet]
            [Route("ObtenerClientes")]
            public IHttpActionResult ObtenerClientes()
            {
                try
                {
                    clienteBLL cliente = new clienteBLL();
                    return Content(HttpStatusCode.OK,  cliente.obtenerClientes());
                }
                catch (Exception)
                {

                    throw;
                }
            }


        
    }
}