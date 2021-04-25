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
    public class GraduationController : Controller
    {
        IGraduationService _graduationService;
        IIdentityService _ıdentityService;
        IGraduationStatusService _graduationStatusService;

        public GraduationController(IIdentityService ıdentityService, IGraduationService graduationService, IGraduationStatusService graduationStatusService)
        {
            _ıdentityService = ıdentityService;
            _graduationService = graduationService;
            _graduationStatusService = graduationStatusService;
        }

        // GET: Graduation
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

        public ActionResult GraduationGetList(int id)
        {

            var graduationGetList = _graduationService.GetGraduationDetails(id).Data;
            ViewBag.PersonelKimlikId = id;
            return View("GraduationGetList", graduationGetList);
        }

        public ActionResult GraduationGet(int id)
        {
            var graduationGrp = _graduationStatusService.GetAll().Data;

            ViewBag.GraduationGrpList = new SelectList(graduationGrp,"EgitimDurumId", "EgitimDurumu");

            var graduationGet = _graduationService.GetById(id).Data;

            return View("GraduationGet", graduationGet);
        }


        [HttpGet]
        public ActionResult GraduationUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult GraduationUpdate(Graduation graduation)

        {
            _graduationService.Update(graduation);

            return RedirectToAction("");
        }
        [HttpGet]
        public ActionResult GraduationGetAdd(int id)
        {

            DropBoxItem();
            ViewBag.PersonelKimlikId = id;
            return View();
        }

        [HttpGet]
        public ActionResult GraduationAdd()

        {
            return View();
        }

        [HttpPost]
        public ActionResult GraduationAdd(Graduation graduation)

        {
            _graduationService.Add(graduation);

            return RedirectToAction("");
        }
        private void DropBoxItem()
        {
            var graduationGrp = _graduationStatusService.GetAll().Data;

            ViewBag.GraduationGrpList = new SelectList(graduationGrp, "EgitimDurumId", "EgitimDurumu");
        }
    }
}