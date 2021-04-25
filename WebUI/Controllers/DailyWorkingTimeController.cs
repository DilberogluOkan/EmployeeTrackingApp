using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class DailyWorkingTimeController : Controller
    {
        IDailyWorkingTimeService _dailyWorkingTimeService;

        public DailyWorkingTimeController(IDailyWorkingTimeService dailyWorkingTimeService)
        {
            _dailyWorkingTimeService = dailyWorkingTimeService;
        }

        // GET: DailyWorkingTime
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DailyWorkingTimeGetAll()
        {
            var result = _dailyWorkingTimeService.GetAll().Data.ToList();
            return View("DailyWorkingTimeGetAll", result);
        }
        public ActionResult DailyWorkingTimeGetById(int id)
        {
            var result = _dailyWorkingTimeService.GetById(id).Data;
            return View("DailyWorkingTimeGetById", result);

        }

        [HttpGet]
        public ActionResult DailyWorkingTimeAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DailyWorkingTimeAdd(DailyWorkingTime dailyWorkingTime)
        {
            _dailyWorkingTimeService.Add(dailyWorkingTime);
            return RedirectToAction("DailyWorkingTimeGetAll");
        }

        [HttpGet]
        public ActionResult DailyWorkingTimeUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DailyWorkingTiUpdate(DailyWorkingTime dailyWorkingTime)
        {
            _dailyWorkingTimeService.Update(dailyWorkingTime);
            return RedirectToAction("DailyWorkingTimeGetAll");
        }

        [HttpGet]
        public ActionResult DailyWorkingTimeDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DailyWorkingTimeDelete(DailyWorkingTime dailyWorkingTime)
        {
            _dailyWorkingTimeService.Delete(dailyWorkingTime);
            return RedirectToAction("DailyWorkingTimeGetAll");
        }
    }
}