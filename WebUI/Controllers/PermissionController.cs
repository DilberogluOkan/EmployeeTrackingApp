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
       
        PermissionManager manager = new PermissionManager(new PermissionDal());
        IdentityManager key = new IdentityManager(new IdentityDal());
        // GET: Permission
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

        public ActionResult PermissionGetList(int id)
        {

            var permissionGetList = manager.GetAllByIdentityId(id).Data;
            return View("PermissionGetList", permissionGetList);
        }

        public ActionResult PermissionGet(int id)
        {
            var permissionGet = manager.GetById(id).Data;

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
            manager.Update(permission);
            return RedirectToAction("");
        }
        [HttpGet]
        public ActionResult PermissionAdd()
        {
            return View();
        }


        [HttpPost]
        public ActionResult PermissionAdd(Permission permission)

        {
            manager.Add(permission);
            return RedirectToAction("");
        }
    }
}