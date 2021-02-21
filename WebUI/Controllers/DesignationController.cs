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
    public class DesignationController : Controller
    {

        DesignationManager manager = new DesignationManager(new DesignationDal());
        IdentityManager key = new IdentityManager(new IdentityDal());
        // GET: Designation
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

        public ActionResult DesignationGetList(int id)
        {

            var designationGetList = manager.GetAllByIdentityId(id).Data;
            return View("DesignationGetList", designationGetList);
        }

        public ActionResult DesignationGet(int id)
        {
            var designationGet = manager.GetById(id).Data;

            return View("DesignationGet", designationGet);
        }


        [HttpGet]
        public ActionResult DesignationUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult DesignationUpdate(Designation designation)

        {
            manager.Update(designation);
            return RedirectToAction("");
        }
    }
}