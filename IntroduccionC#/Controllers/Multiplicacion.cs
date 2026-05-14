using IntroduccionC_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionC_.Controllers
{
    public class MultiplicacionController : Controller
    {
        public static List<Multiplicacion>
        listaMultiplicacion = new List<Multiplicacion>();


        [HttpGet]
        public ActionResult Multiplicacion()
        {
            return View(listaMultiplicacion);
        }


        [HttpPost]
        public ActionResult Multiplicacion(Multiplicacion mul)
        {
            mul.Multiplicar();

            listaMultiplicacion.Add(mul);

            return View(listaMultiplicacion);
        }
    }
}