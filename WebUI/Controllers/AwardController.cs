using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class AwardController : Controller
    {
        AwardManager manager = new AwardManager(new AwardDal());
        IdentityManager key = new IdentityManager(new IdentityDal());
        // GET: Award
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AwardQuery(string id)
        {
            var result = key.GetAll();

            if (!string.IsNullOrEmpty(id))
            {

                return View();
            }
            return View(result);
        }

        public ActionResult AwardGetList(int id)
        {

            var awardGetList = manager.GetAllByIdentityId(id);
            return View("AwardGetList", awardGetList);
        }

        public ActionResult AwardGet(int id)
        {
            var awardGet = manager.GetById(id);

            return View("AwardGet", awardGet);
        }


        [HttpGet]
        public ActionResult AwardUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AwardUpdate(Award award)

        {
            manager.Update(award);
            return RedirectToAction("");
        }
    }
}