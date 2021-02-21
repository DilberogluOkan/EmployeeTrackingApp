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
        MilitaryManager manager = new MilitaryManager(new MilitaryDal());
        IdentityManager key = new IdentityManager(new IdentityDal());
        // GET: Military
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
       
      

        public ActionResult MilitaryGet(int id)
        {
            var militaryGet = manager.GetById(id).Data;
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
            manager.Update(military);
            return RedirectToAction("");
        }
    }
}