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
    public class CourseController : Controller
    {
        CourseManager manager = new CourseManager(new CourseDal());
        IdentityManager key = new IdentityManager(new IdentityDal());
        // GET: Course
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

        public ActionResult CourseGetList(int id)
        {

            var courseGetList = manager.GetAllByIdentityId(id).Data;
            return View("CourseGetList", courseGetList);
        }

        public ActionResult CourseGet(int id)
        {
            var courseGet = manager.GetById(id).Data;

            return View("CourseGet", courseGet);
        }


        [HttpGet]
        public ActionResult CourseUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CourseUpdate(Course course)

        {
            manager.Update(course);
            return RedirectToAction("");
        }
    }
}