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
    public class WorkplaceController : Controller
    {
        WorkplaceManager manager = new WorkplaceManager(new WorkplaceDal());
        IdentityManager key = new IdentityManager(new IdentityDal());
        ShiftInfoManager _shiftInfo = new ShiftInfoManager(new ShiftInfoDal());
        WorkingStatusManager _workingStatus = new WorkingStatusManager(new WorkingStatusDal());
        ServiceInfoManager _serviceInfo = new ServiceInfoManager(new ServiceInfoDal());

        // GET: Workplace
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



        public ActionResult WorkplaceGet(int id)
        {
            Dropbox();
            var workplaceGet = manager.GetById(id).Data;
            return View("WorkplaceGet", workplaceGet);
        }


        [HttpGet]
        public ActionResult WorkplaceUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult WorkplaceUpdate(Workplace workplace)

        {
            manager.Update(workplace);
            return RedirectToAction("");
        }
        [HttpGet]
        public ActionResult WorkplaceAdd()
        {
            Dropbox();
            return View();
        }


        [HttpPost]
        public ActionResult WorkplaceAdd(Workplace workplace)

        {
            manager.Add(workplace);
            return RedirectToAction("");
        }

        private void Dropbox()
        {
            var shiftGrp = _shiftInfo.GetAll().Data.ToList();
            var workingStatusGrp = _workingStatus.GetAll().Data.ToList();
            var serviceInfoGrp = _serviceInfo.GetAll().Data.ToList();


            ViewBag.ShiftGrpList = new SelectList(shiftGrp, "VardiyaId", "Vardiya");
            ViewBag.WorkingStatusGrpList = new SelectList(workingStatusGrp, "IstihtamDurumId", "IstihtamDurum");
            ViewBag.ServiceInfoGrpList = new SelectList(serviceInfoGrp, "ServisBilgisiId", "ServisBilgisi");
        }
    }
}