using Business.Abstract;
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
        IIdentityService _ıdentityService;
        ICourseService _courseService;

        public CourseController(ICourseService courseService, IIdentityService ıdentityService)
        {
            _courseService = courseService;
            _ıdentityService = ıdentityService;
        }

        // GET: Course
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

        public ActionResult CourseGetList(int id)
        {
            ViewBag.PersonelKimlikId = id;
            var courseGetList = _courseService.GetAllByIdentityId(id).Data;
            return View("CourseGetList", courseGetList);
        }

        public ActionResult CourseGet(int id)
        {
            var courseGet = _courseService.GetById(id).Data;
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
            _courseService.Update(course);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult CourseAdd(int id)
        {
            var courseAdd = _courseService.GetById(id).Data;
            ViewBag.PersonelKimlikId = id;
            return View("CourseAdd", courseAdd);
        }


        [HttpPost]
        public ActionResult CourseAdd(Course course)
        {
            _courseService.Add(course);
            return RedirectToAction("");
        }
    }
}