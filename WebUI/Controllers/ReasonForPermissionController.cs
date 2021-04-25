using Business.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class ReasonForPermissionController : Controller
    {
        IReasonForPermissionService _reasonForPermissionService;

        public ReasonForPermissionController(IReasonForPermissionService reasonForPermissionService)
        {
            _reasonForPermissionService = reasonForPermissionService;
        }

        // GET: ReasonForPermission
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReasonForPermissionGetAll()
        {
            var result = _reasonForPermissionService.GetAll().Data.ToList();
            return View("ReasonForPermissionGetAll",result);
        }
        public ActionResult ReasonForPermissionGetById(int id)
        {
            var result = _reasonForPermissionService.GetById(id).Data;
            return View(result);
        }

        [HttpGet]
        public ActionResult ReasonForPermissionAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ReasonForPermissionAdd(ReasonForPermission reasonForPermission)
        {
            _reasonForPermissionService.Add(reasonForPermission);
            return RedirectToAction("ReasonForPermissionGetAll");
        }

        [HttpGet]
        public ActionResult ReasonForPermissionUpdate()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult ReasonForPermissionUpdate(ReasonForPermission reasonForPermission)
        {
            _reasonForPermissionService.Update(reasonForPermission);
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public ActionResult ReasonForPermissionDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ReasonForPermissionDelete(ReasonForPermission reasonForPermission)
        {
            _reasonForPermissionService.Delete(reasonForPermission);
            return RedirectToAction("ReasonForPermissionGetAll");
        }
    }
}