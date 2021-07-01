using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class TisJobCodeController : Controller
    {
        ITisJobCodeService _tisJobCodeService;

        public TisJobCodeController(ITisJobCodeService tisJobCodeService)
        {
            _tisJobCodeService = tisJobCodeService;
        }

        // GET: TisJobCode
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TisJobCodeGetAll()
        {
            var result = _tisJobCodeService.GetAll().Data.ToList();
            return View("TisJobCodeGetAll", result);
        }
        public ActionResult TisJobCodeGetById(int id)
        {
            var result = _tisJobCodeService.GetById(id).Data;
            return View("TisJobCodeGetById", result);

        }

        [HttpGet]
        public ActionResult TisJobCodeAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TisJobCodeAdd(TisJobCode tisJobCode)
        {
            _tisJobCodeService.Add(tisJobCode);
            return RedirectToAction("TisJobCodeGetAll");
        }

        [HttpGet]
        public ActionResult TisJobCodeUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult TisJobCodeUpdate(TisJobCode tisJobCode)
        {
            _tisJobCodeService.Update(tisJobCode);
            return RedirectToAction("TisJobCodeGetAll");
        }

        [HttpGet]
        public ActionResult TisJobCodeDelete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TisJobCodeDelete(TisJobCode tisJobCode)
        {
            _tisJobCodeService.Delete(tisJobCode);
            return RedirectToAction("TisJobCodeGetAll");
        }
    }
}