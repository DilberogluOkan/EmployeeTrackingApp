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

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdaptationQuery(string id)
        {
            var result = manager.GetAll();

            if (!string.IsNullOrEmpty(id))
            {

                return View();
            }
            return View(result);
        }

        public ActionResult AdaptationGetList(int id)
        {

            var adaptationGetList = manager.GetAllByIdentityId(id);
            return View("AdaptationGetList", adaptationGetList);
        }

        public ActionResult AdaptationGet(int id)
        {
            var adaptationGet = manager.GetById(id);

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