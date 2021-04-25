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
    public class WorkingPriceController : Controller
    {
      
        IWorkingPriceService _workingPriceService;
        IIdentityService _ıdentityService;
        IPriceTypeService _priceTypeService;
        IDailyWorkingTimeService _dailyWorkingTimeService;
        IPriceGradeService _priceGradeService;
        IPriceGradeRiseService _priceGradeRiseService;
        public WorkingPriceController(IWorkingPriceService workingPriceService, IIdentityService ıdentityService, IPriceGradeRiseService priceGradeRiseService, IPriceGradeService priceGradeService, IPriceTypeService priceTypeService, IDailyWorkingTimeService dailyWorkingTimeService)
        {
            _workingPriceService = workingPriceService;
            _ıdentityService = ıdentityService;
            _priceGradeRiseService = priceGradeRiseService;
            _priceGradeService = priceGradeService;
            _priceTypeService = priceTypeService;
            _dailyWorkingTimeService = dailyWorkingTimeService;
        }

        // GET: WorkingPrice
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

        public ActionResult WorkingPriceGetList(int id)
        {
            var workingPriceGetList = _workingPriceService.GetPriceDetails(id).Data;
            ViewBag.PersonelKimlikId = id;
            return View("WorkingPriceGetList", workingPriceGetList);
        }

        public ActionResult WorkingPriceGet(int id)
        {
            DropBoxItem();

            var workingPriceGet = _workingPriceService.GetById(id).Data;

            return View("WorkingPriceGet", workingPriceGet);
        }
         

        [HttpGet]
        public ActionResult WorkingPriceUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult WorkingPriceUpdate(WorkingPrice workingPrice)

        {
            _workingPriceService.Update(workingPrice);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult WorkingPriceAdd()
        {
            return View();
        }


        public ActionResult WorkingPriceAddGet(int id)
        {
            DropBoxItem();
            ViewBag.PersonelKimlikId = id;
            var workingPriceAddGet = _workingPriceService.GetById(id).Data;
            return View("WorkingPriceAddGet", workingPriceAddGet);
        }

        [HttpPost]
        public ActionResult WorkingPriceAdd(WorkingPrice workingPrice)

        {
            _workingPriceService.Add(workingPrice);
            return RedirectToAction("");
        }
        private void DropBoxItem()
        {
            var priceTypeGrp = _priceTypeService.GetAll().Data.ToList();
            var dailyWorkingTimeGrp = _dailyWorkingTimeService.GetAll().Data.ToList();
            
            var priceGradeRiseGrp = _priceGradeRiseService.GetAll().Data.ToList();
            ViewBag.PriceTypeGrpList = new SelectList(priceTypeGrp, "UcretTurId", "UcretTuru");
            ViewBag.DailyWorkingTimeGrpList = new SelectList(dailyWorkingTimeGrp, "GunlukCalismaSureId", "GunlukCalismaSuresi");
           
            ViewBag.PriceGradeRiseGrpList = new SelectList(priceGradeRiseGrp, "UcretDerecesineTerfiId", "UcretDerecesineTerfiNedeni");
        }
    }
}