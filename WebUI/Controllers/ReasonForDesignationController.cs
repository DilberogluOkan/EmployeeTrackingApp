using Business.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class ReasonForDesignationController : Controller
    {
        IReasonForDesignationService _reasonForDesignationService;

        public ReasonForDesignationController(IReasonForDesignationService reasonForDesignationService)
        {
            _reasonForDesignationService = reasonForDesignationService;
        }

        // GET: ReasonForDesignation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ReasonForDesignationGetAll()
        {
            var result = _reasonForDesignationService.GetAll().Data.ToList();
            return View("ReasonForDesignationGetAll", result);
        }
        public ActionResult ReasonForDesignationGetById(int id)
        {
            var result = _reasonForDesignationService.GetById(id).Data;
            return View("ReasonForDesignationGetById", result);

        }

        [HttpGet]
        public ActionResult ReasonForDesignationAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult ReasonForDesignationAdd(ReasonForDesignation reasonForDesignation)
        {
            _reasonForDesignationService.Add(reasonForDesignation);
            return RedirectToAction("ReasonForDesignationGetAll");
        }

        [HttpGet]
        public ActionResult ReasonForDesignationUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ReasonForDesignationUpdate(ReasonForDesignation reasonForDesignation)
        {
            _reasonForDesignationService.Update(reasonForDesignation);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult ReasonForDesignationDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ReasonForDesignationDelete(ReasonForDesignation reasonForDesignation)
        {
            _reasonForDesignationService.Delete(reasonForDesignation);
            return RedirectToAction("");
        }
    }
}