using Business.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class DisabilityStatusController : Controller
    {
        IDisabilityStatusService _disabilityStatusService;

        public DisabilityStatusController(IDisabilityStatusService disabilityStatusService)
        {
            _disabilityStatusService = disabilityStatusService;
        }

        // GET: DisabilityStatus
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisabilityStatusGetAll()
        {
            var result = _disabilityStatusService.GetAll().Data.ToList();
            return View("DisabilityStatusGetAll",result);
        }
        public ActionResult DisabilityStatusGetById(int id)
        {
            var result = _disabilityStatusService.GetById(id).Data;
            return View("DisabilityStatusGetById",result);

        }

        [HttpGet]
        public ActionResult DisabilityStatusAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DisabilityStatusAdd(DisabilityStatus disabilityStatus)
        {
            _disabilityStatusService.Add(disabilityStatus);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult DisabilityStatusUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DisabilityStatusUpdate(DisabilityStatus disabilityStatus)
        {
            _disabilityStatusService.Update(disabilityStatus);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult DisabilityStatusDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DisabilityStatusDelete(DisabilityStatus disabilityStatus)
        {
            _disabilityStatusService.Delete(disabilityStatus);
            return RedirectToAction("");
        }
    }
}