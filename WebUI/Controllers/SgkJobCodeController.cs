using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class SgkJobCodeController : Controller
    {
        ISgkJobCodeService _sgkJobCodeService;

        public SgkJobCodeController(ISgkJobCodeService sgkJobCodeService)
        {
            _sgkJobCodeService = sgkJobCodeService;
        }

        // GET: SgkJobCode
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SgkJobCodeGetAll()
        {
            var result = _sgkJobCodeService.GetAll().Data.ToList();
            return View("SgkJobCodeGetAll", result);
        }
        public ActionResult SgkJobCodeGetById(int id)
        {
            var result = _sgkJobCodeService.GetById(id).Data;
            return View("SgkJobCodeGetById", result);

        }

        [HttpGet]
        public ActionResult SgkJobCodeAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SgkJobCodeAdd(SgkJobCode sgkJobCode)
        {
            _sgkJobCodeService.Add(sgkJobCode);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult SgkJobCodeUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SgkJobCodeUpdate(SgkJobCode sgkJobCode)
        {
            _sgkJobCodeService.Update(sgkJobCode);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult SgkJobCodeDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SgkJobCodeDelete(SgkJobCode sgkJobCode)
        {
            _sgkJobCodeService.Delete(sgkJobCode);
            return RedirectToAction("");
        }
    }
}