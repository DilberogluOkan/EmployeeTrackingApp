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
    public class RiseController : Controller
    {
        PromotionManager manager = new PromotionManager(new PromotionDal());
        IdentityManager key = new IdentityManager(new IdentityDal());
        // GET: Rise
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

        public ActionResult RiseGetList(int id)
        {

            var riseGetList = manager.GetAllByIdentityId(id).Data;
            return View("RiseGetList", riseGetList);
        }

        public ActionResult RiseGet(int id)
        {
            var riseGet = manager.GetById(id).Data;

            return View("RiseGet", riseGet);
        }


        [HttpGet]
        public ActionResult RiseUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult RiseUpdate(Promotion promotion)

        {
            manager.Update(promotion);
            return RedirectToAction("");
        }
        [HttpGet]
        public ActionResult RiseAdd()
        {
            return View();
        }


        [HttpPost]
        public ActionResult RiseAdd(Promotion promotion)

        {
            manager.Add(promotion);
            return RedirectToAction("");
        }
    }
}