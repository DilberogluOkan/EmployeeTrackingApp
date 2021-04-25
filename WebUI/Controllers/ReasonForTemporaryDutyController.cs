using Business.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class ReasonForTemporaryDutyController : Controller
    {
        IReasonForTemporaryDutyService _reasonForTemporaryDutyService;

        public ReasonForTemporaryDutyController(IReasonForTemporaryDutyService reasonForTemporaryDutyService)
        {
            _reasonForTemporaryDutyService = reasonForTemporaryDutyService;
        }

        // GET: ReasonForTemporaryDuty
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ReasonForTemporaryDutyGetAll()
        {
            var result = _reasonForTemporaryDutyService.GetAll().Data.ToList();
            return View("ReasonForTemporaryDutyGetAll", result);
        }
        public ActionResult ReasonForTemporaryDutyGetById(int id)
        {
            var result = _reasonForTemporaryDutyService.GetById(id).Data;
            return View("ReasonForTemporaryDutyGetById", result);

        }

        [HttpGet]
        public ActionResult ReasonForTemporaryDutyAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult ReasonForTemporaryDutyAdd(ReasonForTemporaryDuty reasonForTemporaryDuty)
        {
            _reasonForTemporaryDutyService.Add(reasonForTemporaryDuty);
            return RedirectToAction("ReasonForTemporaryDutyGetAll");
        }

        [HttpGet]
        public ActionResult ReasonForTemporaryDutyUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ReasonForTemporaryDutyUpdate(ReasonForTemporaryDuty reasonForTemporaryDuty)
        {
            _reasonForTemporaryDutyService.Update(reasonForTemporaryDuty);
            return RedirectToAction("ReasonForTemporaryDutyGetAll");
        }

        [HttpGet]
        public ActionResult ReasonForTemporaryDutyDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ReasonForTemporaryDutyDelete(ReasonForTemporaryDuty reasonForTemporaryDuty)
        {
            _reasonForTemporaryDutyService.Delete(reasonForTemporaryDuty);
            return RedirectToAction("");
        }
    }
}