using FinalRendiciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalRendiciones.Controllers
{
    public class RendicionesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agregar()
        {
            GestorRendiciones GR = new GestorRendiciones();
            Rendicion R = new Rendicion();
            R.viatico = new Viatico();
            R.nombreEmpleado = GR.ObtenerNombres();
            return View(R);
        }

        [HttpPost]
        public ActionResult Agregar(Rendicion nuevoViatico)
        {
            GestorRendiciones GR = new GestorRendiciones();
            GR.Agregar(nuevoViatico.viatico);
            return View("Index");
        }

        public ActionResult Listar()
        {
            GestorRendiciones GR = new GestorRendiciones();
            List<ViaticoDto> lista = GR.Listar();
            return View(lista);
            
        }
    }
}
