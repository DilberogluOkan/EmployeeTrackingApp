using Business.Abstract;
using Business.Abstract.Dynamic;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class CriminalController : Controller
    {
        IIdentityService _ıdentityService;
        ICriminalService _criminalService;
        IReasonForCriminalService _reasonForCriminalService;
        public CriminalController(IIdentityService ıdentityService, ICriminalService criminalService, IReasonForCriminalService reasonForCriminalService)
        {
            _ıdentityService = ıdentityService;
            _criminalService = criminalService;
            _reasonForCriminalService = reasonForCriminalService;
        }

        // GET: Criminal
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

        public ActionResult CriminalGetList(int id)
        {

            var criminalGetList = _criminalService.GetCriminalDetails(id).Data;
            ViewBag.PersonelKimlikId = id;
            return View("CriminalGetList", criminalGetList);
        }

        public ActionResult CriminalGet(int id)
        {
            DropBoxItem();
            var criminalGet = _criminalService.GetById(id).Data;
            return View("CriminalGet", criminalGet);
        }


        [HttpGet]
        public ActionResult CriminalUpdate()
        {
            
            return View();
        }


        [HttpPost]
        public ActionResult CriminalUpdate(Criminal criminal)
        {
            _criminalService.Update(criminal);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult CriminalAdd(int id)
        {
            DropBoxItem();
            var criminalAdd = _criminalService.GetById(id).Data;
            ViewBag.PersonelKimlikId = id;
            return View("CriminalAdd", criminalAdd);
        }


        [HttpPost]
        public ActionResult CriminalAdd(Criminal criminal)
        {
            _criminalService.Add(criminal);
            return RedirectToAction("");
        }
        private void DropBoxItem()
        {
            var reasonForCriminal = _reasonForCriminalService.GetAll().Data.ToList();
            ViewBag.reasonForCriminalList = new SelectList(reasonForCriminal, "CezaNedenId", "CezaNedeni");
        }
    }
}