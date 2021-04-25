using Business.Abstract;
using Business.Abstract.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        IIdentityService _ıdentityService;
        IWorkplaceService _workplaceService;
        IDisabilityStatusService _disabilityStatusService;
        public HomeController(IIdentityService ıdentityService, IWorkplaceService workplaceService, IDisabilityStatusService disabilityStatusService)
        {
            _ıdentityService = ıdentityService;
            _workplaceService = workplaceService;
            _disabilityStatusService = disabilityStatusService;
        }

        public ActionResult Index()
        {
            PersonCartCounts();
            WorkplaceCardCounts();
            EngineerPersonCount();
            PrivateStatus();
            return View();
        }
        private void PersonCartCounts()
        {
            var allEmployeeCount = _ıdentityService.GetAll().Data.Count();
            var womenCount = _ıdentityService.GetGenderCount(1).Data.Count();
            var manCount = _ıdentityService.GetGenderCount(2).Data.Count();
            var ageCount = _ıdentityService.GetAgeCount().Data.Count();
            var currentStatusCount = _ıdentityService.GetCurrentStatuCount(3).Data.Count();

            ViewBag.currentStatusCount = currentStatusCount;
            ViewBag.AgeCount = ageCount;
            ViewBag.ManCount = manCount;
            ViewBag.WomenCount = womenCount;
            ViewBag.AllEmployeeCount = allEmployeeCount;
        }
        private void WorkplaceCardCounts()
        {
            var afgmCount = _ıdentityService.AfgmForCount().Data.Count();
            var asalCount = _ıdentityService.AsalForCount().Data.Count();
            var asfatCount = _ıdentityService.AsfatForCount().Data.Count();
            var ashgmCount = _ıdentityService.AshgmForCount().Data.Count();
            var dzkkCount = _ıdentityService.DzkkForCount().Data.Count();
            var gnkurCount = _ıdentityService.GnkurForCount().Data.Count();
            var hgmCount = _ıdentityService.HgmForCount().Data.Count();
            var hvkkCount = _ıdentityService.HvkkForCount().Data.Count();
            var kkkCount = _ıdentityService.KkkForCount().Data.Count();
            var lgmCount = _ıdentityService.LgmForCount().Data.Count();
            var msuCount = _ıdentityService.MsuForCount().Data.Count();
            var tedgmCount = _ıdentityService.TedgmForCount().Data.Count();
            var tgmCount = _ıdentityService.TgmForCount().Data.Count();
            var yhgmCount = _ıdentityService.YhgmForCount().Data.Count();

            var sum = afgmCount + asalCount + asfatCount + ashgmCount + dzkkCount
                + gnkurCount + hgmCount + hvkkCount + kkkCount + lgmCount + msuCount + tedgmCount + tgmCount + yhgmCount;

            ViewBag.AfgmCount = afgmCount;//
            ViewBag.AsalCount = asalCount;//
            ViewBag.AsfatCount = asfatCount;//
            ViewBag.AshgmCount = ashgmCount;//
            ViewBag.DzkkCount = dzkkCount;//
            ViewBag.GnkurCount = gnkurCount;//
            ViewBag.HgmCount = hgmCount;
            ViewBag.HvkkCount = hvkkCount;
            ViewBag.KkkCount = kkkCount;
            ViewBag.LgmCount = lgmCount;
            ViewBag.MsuCount = msuCount;
            ViewBag.TedgmCount = tedgmCount;
            ViewBag.TgmCount = tgmCount;
            ViewBag.YhgmCount = yhgmCount;
            ViewBag.Sum = sum;
        }
        private void EngineerPersonCount()
        {
            double engineerPersonCount = _ıdentityService.EngineerPersonCount().Data.Count();
            double allEmployeeCount = _ıdentityService.GetAll().Data.Count();
            double mod = (engineerPersonCount * 100) / allEmployeeCount;



            ViewBag.EngineerPersonCount = engineerPersonCount;
            ViewBag.ModEngineerPerson = Math.Round(mod,2);
        }
        private void PrivateStatus()
        {
            double disabilityStatus = _disabilityStatusService.GetDisabilityCount().Data.Count();
            double allEmployeeCount = _ıdentityService.GetAll().Data.Count();
            double mod = (disabilityStatus * 100) / allEmployeeCount;
            ViewBag.DisabilityStatus = disabilityStatus;
            
            ViewBag.ModDisabilityStatus = Math.Round(mod, 2);
        }

    }
}