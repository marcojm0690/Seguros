using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Seguros.DAL;
using System.Web.Mvc;

namespace Seguros.Controllers
{
    public class InsuranceController : Controller
    {
        private IInsuranceRepository _insuranceRepository;
        public InsuranceController()
        {
            this._insuranceRepository = new InsuranceRepository(new InsuranceContext());
        }

        public ActionResult Add()
        {
            ViewBag.Title = "Agregar Seguro";

            return View();
        }

        public ActionResult Query()
        {
            var clients = from client in _insuranceRepository.GetAllClients() select client;

            ViewBag.Title = "Consultar Cliente";

            return View(clients);
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
