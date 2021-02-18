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
        // GET: Designation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DesignationQuery(string id)
        {
            var result = manager.GetAll();

            if (!string.IsNullOrEmpty(id))
            {

                return View();
            }
            return View(result);
        }

        public ActionResult DesignationGetList(int id)
        {

            var designationGetList = manager.GetAllByIdentityId(id);
            return View("DesignationGetList", designationGetList);
        }

        public ActionResult DesignationGet(int id)
        {
            var designationGet = manager.GetById(id);

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