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
    public class CriminalController : Controller
    {

        CriminalManager manager = new CriminalManager(new CriminalDal());
        IdentityManager key = new IdentityManager(new IdentityDal());
        // GET: Criminal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CriminalQuery(string id)
        {
            var result = key.GetAll();

            if (!string.IsNullOrEmpty(id))
            {

                return View();
            }
            return View(result);
        }

        public ActionResult CriminalGetList(int id)
        {

            var criminalGetList = manager.GetAllByIdentityId(id);
            return View("CriminalGetList", criminalGetList);
        }

        public ActionResult CriminalGet(int id)
        {
            var criminalGet = manager.GetById(id);

            return View("CriminalGet", criminalGet);
        }


        [HttpGet]
        public ActionResult CriminalUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CriminalUpdate(Criminal criminal)

        {
            manager.Update(criminal);
            return RedirectToAction("");
        }
    }
}