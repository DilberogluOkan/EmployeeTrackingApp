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
    public class GraduationController : Controller
    {
        GraduationManager manager = new GraduationManager(new GraduationDal());
        // GET: Graduation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GraduationQuery(string id)
        {
            var result = manager.GetAll();

            if (!string.IsNullOrEmpty(id))
            {
                
                return View();
            }
            return View(result);
        }

        public ActionResult GraduationGetList(int id)
        {

            var graduationGetList = manager.GetAllByIdentityId(id);
            return View("GraduationGetList", graduationGetList);
        }

        public ActionResult GraduationGet(int id)
        {
            var graduationGet = manager.GetById(id);

            return View("GraduationGet", graduationGet);
        }


        [HttpGet]
        public ActionResult GraduationUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult GraduationUpdate(Graduation graduation)

        {
            manager.Update(graduation);

            return RedirectToAction("");
        }
    }
}