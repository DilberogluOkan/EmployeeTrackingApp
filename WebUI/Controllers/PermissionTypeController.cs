using Business.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class PermissionTypeController : Controller
    {
        IPermissionTypeService _permissionTypeService;

        public PermissionTypeController(IPermissionTypeService permissionTypeService)
        {
            _permissionTypeService = permissionTypeService;
        }

        // GET: PermissionType
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PermissionTypeGetAll()
        {
            var result = _permissionTypeService.GetAll().Data.ToList();
            return View("PermissionTypeGetAll", result);
        }
        public ActionResult PermissionTypeGetById(int id)
        {
            var result = _permissionTypeService.GetById(id).Data;
            return View("PermissionTypeGetById",result);

        }

        [HttpGet]
        public ActionResult PermissionTypeAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult PermissionTypeAdd(PermissionType permissionType)
        {
            _permissionTypeService.Add(permissionType);
            return RedirectToAction("PermissionTypeGetAll");
        }

        [HttpGet]
        public ActionResult PermissionTypeUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult PermissionTypeUpdate(PermissionType permissionType)
        {
            _permissionTypeService.Update(permissionType);
            return RedirectToAction("PermissionTypeGetAll");
        }

        [HttpGet]
        public ActionResult PermissionTypeDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult PermissionTypeDelete(PermissionType permissionType)
        {
            _permissionTypeService.Delete(permissionType);
            return RedirectToAction("PermissionTypeGetAll");
        }
    }
}