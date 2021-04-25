using Business.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class WorkingStatusController : Controller
    {
        IWorkingStatusService _workingStatusService;

        public WorkingStatusController(IWorkingStatusService workingStatusService)
        {
            _workingStatusService = workingStatusService;
        }

        // GET: WorkingStatus
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult WorkingStatusGetAll()
        {
            var result = _workingStatusService.GetAll().Data.ToList();
            return View("WorkingStatusGetAll", result);
        }
        public ActionResult WorkingStatusGetById(int id)
        {
            var result = _workingStatusService.GetById(id).Data;
            return View("WorkingStatusGetById",result);

        }

        [HttpGet]
        public ActionResult WorkingStatusAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult WorkingStatusAdd(WorkingStatus workingStatus)
        {
            _workingStatusService.Add(workingStatus);
            return RedirectToAction("WorkingStatusGetAll");
        }

        [HttpGet]
        public ActionResult WorkingStatusUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult WorkingStatusUpdate(WorkingStatus workingStatus)
        {
            _workingStatusService.Update(workingStatus);
            return RedirectToAction("WorkingStatusGetAll");
        }

        [HttpGet]
        public ActionResult WorkingStatusDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult WorkingStatusDelete(WorkingStatus workingStatus)
        {
            _workingStatusService.Delete(workingStatus);
            return RedirectToAction("WorkingStatusGetAll");
        }
    }
}