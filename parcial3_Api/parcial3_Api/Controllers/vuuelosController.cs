using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net.Http;

namespace parcial3_Api.Controllers
{
    public class vuelosController : ApiController
    {
        [System.Web.Http.HttpPost]
        public IHttpActionResult Index()
        {
            using (Models.aeroParcialEntities db = new Models.aeroParcialEntities())
            {
                var oVuelos = new Models.vuelos();

                oVuelos.avion = "Carcamo-23";
                oVuelos.salida = Convert.ToDateTime("2020-02-23 12:25:12");
                oVuelos.llegada = Convert.ToDateTime("2020-02-23 15:25:12");
                oVuelos.numPasajeros = 150;


                db.vuelos.Add(oVuelos);
                db.SaveChanges();

                return Ok("exito");

            }


        }


    }
}