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
    public class WorkplaceController : Controller
    {
        IWorkplaceService _workplaceService;
       

        public WorkplaceController(IWorkplaceService workplaceService)
        {
            _workplaceService = workplaceService;
           
        }
     
        // GET: Workplace
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult WorkplaceUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult WorkplaceUpdate(Workplace workplace)

        {
            _workplaceService.Update(workplace);
            return RedirectToAction("");
        }
        [HttpGet]
        public ActionResult WorkplaceAdd()
        {
            return View();
        }


        [HttpPost]
        public ActionResult WorkplaceAdd(Workplace workplace)

        {
            _workplaceService.Add(workplace);
            return RedirectToAction("");
        }

        public ActionResult WorkplaceGetAll()
        {
            var result = _workplaceService.GetAll().Data.ToList();
            return View(result);
        }
        public ActionResult WorkplaceById(int id)
        {
            var result = _workplaceService.GetById(id).Data;
            return View(result);

        }

       

        [HttpGet]
        public ActionResult WorkplaceDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult WorkplaceDelete(Workplace workplace)
        {
            _workplaceService.Delete(workplace);
            return RedirectToAction("");
        }

        //private void DropboxItems()
        //{
        //    var shiftGrp = _shiftInfoService.GetAll().Data.ToList();
        //    var workingStatusGrp = _workingStatusService.GetAll().Data.ToList();
        //    var serviceInfoGrp = _serviceInfoService.GetAll().Data.ToList();


        //    ViewBag.ShiftGrpList = new SelectList(shiftGrp, "VardiyaId", "Vardiya");
        //    ViewBag.WorkingStatusGrpList = new SelectList(workingStatusGrp, "IstihtamDurumId", "IstihtamDurum");
        //    ViewBag.ServiceInfoGrpList = new SelectList(serviceInfoGrp, "ServisBilgisiId", "ServisBilgisi");
        //}


        //WorkplaceManager manager = new WorkplaceManager(new WorkplaceDal());
        //IdentityManager key = new IdentityManager(new IdentityDal());
        //ShiftInfoManager _shiftInfo = new ShiftInfoManager(new ShiftInfoDal());
        //WorkingStatusManager _workingStatus = new WorkingStatusManager(new WorkingStatusDal());
        //ServiceInfoManager _serviceInfo = new ServiceInfoManager(new ServiceInfoDal());

    }
}