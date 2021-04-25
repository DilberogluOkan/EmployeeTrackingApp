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
    public class MilitaryController : Controller
    {
        
        IIdentityService _ıdentityService;
        IMilitaryService _militaryService;

        public MilitaryController(IIdentityService ıdentityService, IMilitaryService militaryService)
        {
            _ıdentityService = ıdentityService;
            _militaryService = militaryService;
        }

        // GET: Military
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IndexQuery(string tcNo)
        {
            var result = _ıdentityService.GetBytc(tcNo).Data;
            return View(result);
        }
       
      

        public ActionResult MilitaryGet(int id)
        {
            var militaryGet = _militaryService.GetById(id).Data;
            return View("MilitaryGet", militaryGet);
        }


        [HttpGet]
        public ActionResult MilitaryUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult MilitaryUpdate(Military military)

        {
            _militaryService.Update(military);
            return RedirectToAction("");
        }
    }
}