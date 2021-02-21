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
    public class AdaptationController : Controller
    {
        AdaptationManager manager = new AdaptationManager(new AdaptationDal());
        IdentityManager key = new IdentityManager(new IdentityDal());

        
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
       

        public ActionResult AdaptationGetList(int id)
        {

            var adaptationGetList = manager.GetAllByIdentityId(id).Data;
            return View("AdaptationGetList", adaptationGetList);
        }

        public ActionResult AdaptationGet(int id)
        {
            var adaptationGet = manager.GetById(id).Data;

            return View("AdaptationGet", adaptationGet);
        }


        [HttpGet]
        public ActionResult AdaptationUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AdaptationUpdate(Adaptation adaptation)

        {
            manager.Update(adaptation);
            return RedirectToAction("");
        }
    }
}