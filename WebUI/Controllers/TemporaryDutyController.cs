using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class TemporaryDutyController : Controller
    {

        IIdentityService _ıdentityService;
        ITemporaryDutyService _temporaryDutyService;

        public TemporaryDutyController(IIdentityService ıdentityService, ITemporaryDutyService temporaryDutyService)
        {
            _ıdentityService = ıdentityService;
            _temporaryDutyService = temporaryDutyService;
        }

        // GET: TemporaryDuty
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IndexQuery(string tcNo)
        {
            var result = _ıdentityService.GetPersonDetails(tcNo).Data;
            return View(result);
        }

        public ActionResult TemporaryDutyGetList(int id)
        {

            var temporaryDutyGetList = _temporaryDutyService.GetTemporaryDutyDetails(id).Data;
            return View("TemporaryDutyGetList", temporaryDutyGetList);
        }

        public ActionResult TemporaryDutyGet(int id)
        {
            var temporaryDutyGet = _temporaryDutyService.GetTemporaryDutyDetails(id).Data;

            return View("TemporaryDutyGet", temporaryDutyGet);
        }


        [HttpGet]
        public ActionResult TemporaryDutyUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult TemporaryDutyUpdate(TemporaryDuty temporaryDuty)

        {
            _temporaryDutyService.Update(temporaryDuty);
            return RedirectToAction("");
        }
        [HttpGet]
        public ActionResult TemporaryDutyAdd(int id)
        {
            var temporaryDutyAdd = _temporaryDutyService.GetTemporaryDutyDetails(id).Data;

            return View("TemporaryDutyAdd", temporaryDutyAdd);
        }


        [HttpPost]
        public ActionResult TemporaryDutyAdd(TemporaryDuty temporaryDuty)

        {
            _temporaryDutyService.Add(temporaryDuty);
            return RedirectToAction("");
        }
    }
}