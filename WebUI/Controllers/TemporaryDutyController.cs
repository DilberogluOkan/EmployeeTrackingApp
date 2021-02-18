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
    public class TemporaryDutyController : Controller
    {

        TemporaryDutyManager manager = new TemporaryDutyManager(new TemporaryDutyDal());
        IdentityManager key = new IdentityManager(new IdentityDal());

        // GET: TemporaryDuty
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TemporaryDutyQuery(string id)
        {
            var result = key.GetAll();

            if (!string.IsNullOrEmpty(id))
            {

                return View();
            }
            return View(result);
        }

        public ActionResult TemporaryDutyGetList(int id)
        {

            var temporaryDutyGetList = manager.GetAllByIdentityId(id);
            return View("TemporaryDutyGetList", temporaryDutyGetList);
        }

        public ActionResult TemporaryDutyGet(int id)
        {
            var temporaryDutyGet = manager.GetById(id);

            return View("TemporaryDutyGet", temporaryDutyGet);
        }


        [HttpGet]
        public ActionResult TemporaryDutyUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult TemporaryDutyUpdate(TemporaryDuty temporaryDuty)

        {
            manager.Update(temporaryDuty);
            return RedirectToAction("");
        }
    }
}