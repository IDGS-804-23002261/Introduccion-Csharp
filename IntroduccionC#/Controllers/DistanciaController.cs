using IntroduccionC_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionC_.Controllers
{
    public class DistanciaController : Controller
    {
        public static List<DistanciaEntreDosPuntos>
        listaDistancias = new List<DistanciaEntreDosPuntos>();


        [HttpGet]
        public ActionResult Distancia()
        {
            return View("Distancia", listaDistancias);
        }


        [HttpPost]
        public ActionResult Distancia(DistanciaEntreDosPuntos dis)
        {
            dis.CalcularDistancia();

            listaDistancias.Add(dis);

            return View("Distancia", listaDistancias);
        }
    }
}