using Business.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class ReasonForCriminalController : Controller
    {
        IReasonForCriminalService _reasonForCriminalService;

        public ReasonForCriminalController(IReasonForCriminalService reasonForCriminalService)
        {
            _reasonForCriminalService = reasonForCriminalService;
        }

        // GET: ReasonForCriminal
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ReasonForCriminalGetAll()
        {
            var result = _reasonForCriminalService.GetAll().Data.ToList();
            return View("ReasonForCriminalGetAll", result);
        }
        public ActionResult ReasonForCriminalGetById(int id)
        {
            var result = _reasonForCriminalService.GetById(id).Data;
            return View("ReasonForCriminalGetById", result);

        }

        [HttpGet]
        public ActionResult ReasonForCriminalAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult ReasonForCriminalAdd(ReasonForCriminal reasonForCriminal)
        {
            _reasonForCriminalService.Add(reasonForCriminal);
            return RedirectToAction("ReasonForCriminalGetAll");
        }

        [HttpGet]
        public ActionResult ReasonForCriminalUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ReasonForCriminalUpdate(ReasonForCriminal reasonForCriminal)
        {
            _reasonForCriminalService.Update(reasonForCriminal);
            return RedirectToAction("ReasonForCriminalGetAll");
        }

        [HttpGet]
        public ActionResult ReasonForCriminalDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ReasonForCriminalDelete(ReasonForCriminal reasonForCriminal)
        {
            _reasonForCriminalService.Delete(reasonForCriminal);
            return RedirectToAction("ReasonForCriminalGetAll");
        }
    }
}