using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Seguros.DAL;
using System.Web.Mvc;
using Seguros.DAL.Models;

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Insurance insurance)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this._insuranceRepository.AddInsurance(insurance);
                    this._insuranceRepository.Save();
                    return RedirectToAction("Query");
                }
            }
            catch (Exception ex)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(insurance);
        }

        public ActionResult Details(int? ClientID)
        {
            var insurance = new Seguros.DAL.Models.Insurance();
            if (ClientID != null)
            {
                insurance = _insuranceRepository.GetInsuranceById(ClientID);
            }
            return View(insurance);
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
