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

        public ActionResult CourseQuery(string id)
        {
            var result = key.GetAll();

            if (!string.IsNullOrEmpty(id))
            {

                return View();
            }
            return View(result);
        }

        public ActionResult CourseGetList(int id)
        {

            var courseGetList = manager.GetAllByIdentityId(id);
            return View("CourseGetList", courseGetList);
        }

        public ActionResult CourseGet(int id)
        {
            var courseGet = manager.GetById(id);

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