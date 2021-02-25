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

        [HttpPost]
        public ActionResult IndexQuery(string tcNo)
        {
            var result = key.GetBytc(tcNo).Data;
            return View(result);
        }

        public ActionResult AwardGetList(int id)
        {

            var awardGetList = manager.GetAllByIdentityId(id).Data;
            return View("AwardGetList", awardGetList);
        }

        public ActionResult AwardGet(int id)
        {
            var awardGet = manager.GetById(id).Data;

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
        [HttpGet]
        public ActionResult AwardAdd()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AwardAdd(Award award)

        {
            manager.Add(award);
            return RedirectToAction("AwardGetList");
        }
    }
}