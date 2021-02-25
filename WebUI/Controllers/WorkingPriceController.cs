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
        WorkingPriceManager manager = new WorkingPriceManager(new WorkingPriceDal());
        IdentityManager key = new IdentityManager(new IdentityDal());
        PriceTypeManager _priceType = new PriceTypeManager(new PriceTypeDal());
        DailyWorkingTimeManager _dailyWorkingTime = new DailyWorkingTimeManager(new DailyWorkingTimeDal());
        PriceGradeManager _priceGrade = new PriceGradeManager(new PriceGradeDal());
        PriceGradeRiseManager _priceGradeRise = new PriceGradeRiseManager(new PriceGradeRiseDal());

        // GET: WorkingPrice
        public ActionResult Index()
        {
            return View();
        }
       
        

        [HttpPost]
        public ActionResult IndexQuery(string tcNo)
        {
            var result = key.GetBytc(tcNo).Data;
            return View(result);
        }

        public ActionResult WorkingPriceGetList(int id)
        {

            var workingPriceGetList = manager.GetAllByIdentityId(id).Data;
            return View("WorkingPriceGetList", workingPriceGetList);
        }

        public ActionResult WorkingPriceGet(int id)
        {
            var priceTypeGrp = _priceType.GetAll().Data.ToList();
            var dailyWorkingTimeGrp = _dailyWorkingTime.GetAll().Data.ToList();
            var priceGradeGrp = _priceGrade.GetAll().Data.ToList();
            var priceGradeRiseGrp = _priceGradeRise.GetAll().Data.ToList();


            ViewBag.ShiftGrpList = new SelectList(priceTypeGrp, "UcretTurId", "UcretTuru");
            ViewBag.WorkingStatusGrpList = new SelectList(dailyWorkingTimeGrp, "GunlukCalismaSureId", "GunlukCalismaSuresi");
            ViewBag.PriceGradeGrpList = new SelectList(priceGradeGrp, "UcretDereceId", "UcretDerecesi");
            ViewBag.PriceGradeRiseGrpList = new SelectList(priceGradeRiseGrp, "UcretDerecesiTerfiId", "UcretDerecesiTerfiNedeni");

            var workingPriceGet = manager.GetById(id).Data;

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
            manager.Update(workingPrice);
            return RedirectToAction("");
        }
    }
}