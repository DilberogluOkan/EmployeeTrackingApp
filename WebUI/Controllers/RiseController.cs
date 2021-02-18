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
        // GET: Rise
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RiseQuery(string id)
        {
            var result = manager.GetAll();

            if (!string.IsNullOrEmpty(id))
            {

                return View();
            }
            return View(result);
        }

        public ActionResult RiseGetList(int id)
        {

            var riseGetList = manager.GetAllByIdentityId(id);
            return View("RiseGetList", riseGetList);
        }

        public ActionResult RiseGet(int id)
        {
            var riseGet = manager.GetById(id);

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
    }
}