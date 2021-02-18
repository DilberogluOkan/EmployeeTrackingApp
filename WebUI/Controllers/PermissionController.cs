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

        public ActionResult PermissionQuery(string id)
        {
            var result = key.GetAll();

            if (!string.IsNullOrEmpty(id))
            {

                return View();
            }
            return View(result);
        }

        public ActionResult PermissionGetList(int id)
        {

            var permissionGetList = manager.GetAllByIdentityId(id);
            return View("PermissionGetList", permissionGetList);
        }

        public ActionResult PermissionGet(int id)
        {
            var permissionGet = manager.GetById(id);

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
    }
}