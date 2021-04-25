using Business.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class CurrentStatusController : Controller
    {
        ICurrentStatusService _currentStatusService;

        public CurrentStatusController(ICurrentStatusService currentStatusService)
        {
            _currentStatusService = currentStatusService;
        }

        // GET: CurrentStatus
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CurrentStatusGetAll()
        {
            var result = _currentStatusService.GetAll().Data.ToList();
            return View("CurrentStatusGetAll", result);
        }
        public ActionResult CurrentStatusGetById(int id)
        {
            var result = _currentStatusService.GetById(id).Data;
            return View("CurrentStatusGetById", result);

        }

        [HttpGet]
        public ActionResult CurrentStatusAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CurrentStatusAdd(CurrentStatus currentStatus)
        {
            _currentStatusService.Add(currentStatus);
            return RedirectToAction("CurrentStatusGetAll");
        }

        [HttpGet]
        public ActionResult CurrentStatusUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CurrentStatusUpdate(CurrentStatus currentStatus)
        {
            _currentStatusService.Update(currentStatus);
            return RedirectToAction("CurrentStatusGetAll");
        }

        [HttpGet]
        public ActionResult CurrentStatusDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CurrentStatusDelete(CurrentStatus currentStatus)
        {
            _currentStatusService.Delete(currentStatus);
            return RedirectToAction("CurrentStatusGetAll");
        }
    }

}