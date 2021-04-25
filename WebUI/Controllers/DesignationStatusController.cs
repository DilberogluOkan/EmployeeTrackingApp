using Business.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class DesignationStatusController : Controller
    {
        IDesignationStatusService _designationStatusService;

        public DesignationStatusController(IDesignationStatusService designationStatusService)
        {
            _designationStatusService = designationStatusService;
        }

        // GET: DesignationStatus
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DesignationStatusGetAll()
        {
            var result = _designationStatusService.GetAll().Data.ToList();
            return View("DesignationStatusGetAll", result);
        }
        public ActionResult DesignationStatusGetById(int id)
        {
            var result = _designationStatusService.GetById(id).Data;
            return View("DesignationStatusGetById", result);

        }

        [HttpGet]
        public ActionResult DesignationStatusAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DesignationStatusAdd(DesignationStatus designationStatus)
        {
            _designationStatusService.Add(designationStatus);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult DesignationStatusUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DesignationStatusUpdate(DesignationStatus designationStatus)
        {
            _designationStatusService.Update(designationStatus);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult DesignationStatusDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DesignationStatusDelete(DesignationStatus designationStatus)
        {
            _designationStatusService.Delete(designationStatus);
            return RedirectToAction("");
        }
    }
}