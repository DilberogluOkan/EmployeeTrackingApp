using Business.Abstract;
using Business.Abstract.Dynamic;
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
    public class PermissionController : Controller
    {
       
        IPermissionService _permissionService;
        IIdentityService _ıdentityService;
        IPermissionTypeService _permissionTypeService;
        IReasonForPermissionService _reasonForPermissionService;

        public PermissionController(IIdentityService ıdentityService, IPermissionService permissionService, IPermissionTypeService permissionTypeService, IReasonForPermissionService reasonForPermissionService)
        {
            _ıdentityService = ıdentityService;
            _permissionService = permissionService;
            _permissionTypeService = permissionTypeService;
            _reasonForPermissionService = reasonForPermissionService;
        }

        // GET: Permission
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

        public ActionResult PermissionGetList(int id)
        {

            var permissionGetList = _permissionService.GetPermissionDetails(id).Data;
            ViewBag.PersonelKimlikId = id;
            return View("PermissionGetList", permissionGetList);
        }

        public ActionResult PermissionGet(int id)
        {
            DropBoxItem();
            var permissionGet = _permissionService.GetById(id).Data;

            return View("PermissionGet",permissionGet);
        }


        [HttpGet]
        public ActionResult PermissionUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult PermissionUpdate(Permission permission)

        {
            _permissionService.Update(permission);
            return RedirectToAction("");
        }
        [HttpGet]
        public ActionResult PermissionAdd(int id)
        {
            DropBoxItem();

            var permissionAdd = _permissionService.GetById(id).Data;
            ViewBag.PersonelKimlikId = id;
            return View("PermissionAdd", permissionAdd);
        }


        [HttpPost]
        public ActionResult PermissionAdd(Permission permission)

        {
            _permissionService.Add(permission);
            return RedirectToAction("");
        }
        private void DropBoxItem()
        {
            var permissionTypeGrp = _permissionTypeService.GetAll().Data;
            var reasonForPermissionGrp = _reasonForPermissionService.GetAll().Data;

            ViewBag.PermissionTypeGrpList = new SelectList(permissionTypeGrp, "IzinTurId", "IzinTuru");
            ViewBag.ReasonForPermissionGrpList = new SelectList(reasonForPermissionGrp, "IzinNedenId", "IzinNedeni");
        }
    }
}