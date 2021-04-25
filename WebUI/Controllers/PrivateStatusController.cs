using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class PrivateStatusController : Controller
    {
        IPrivateStatusService _privateStatusService;

        public PrivateStatusController(IPrivateStatusService privateStatusService)
        {
            _privateStatusService = privateStatusService;
        }

        // GET: PrivateStatus
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PrivateStatusGetAll()
        {
            var result = _privateStatusService.GetAll().Data.ToList();
            return View("PrivateStatusGetAll", result);
        }
        public ActionResult PrivateStatusGetById(int id)
        {
            var result = _privateStatusService.GetById(id).Data;
            return View("PrivateStatusGetById", result);

        }

        [HttpGet]
        public ActionResult PrivateStatusAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult PrivateStatusAdd(PrivateStatus privateStatus)
        {
            _privateStatusService.Add(privateStatus);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult PrivateStatusUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult PrivateStatusUpdate(PrivateStatus privateStatus)
        {
            _privateStatusService.Update(privateStatus);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult PrivateStatusDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult PrivateStatusDelete(PrivateStatus privateStatus)
        {
            _privateStatusService.Delete(privateStatus);
            return RedirectToAction("");
        }
    }
}