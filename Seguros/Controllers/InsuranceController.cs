using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seguros.Controllers
{
    public class InsuranceController : Controller
    {
        public ActionResult Add()
        {
            ViewBag.Title = "Agregar Seguro";

            return View();
        }

        public ActionResult Query()
        {
            ViewBag.Title = "Consultar Seguro";

            return View();
        }
        public ActionResult Delete()
        {
            ViewBag.Title = "Eliminar Seguro";

            return View();
        }
        public ActionResult Modify()
        {
            ViewBag.Title = "Modificar Seguro";

            return View();
        }
    }
}
