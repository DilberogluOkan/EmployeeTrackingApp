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
    public class BirthCertificateController : Controller
    {
        BirthCertificateManager manager = new BirthCertificateManager(new BirthCertificateDal());
        IdentityManager key = new IdentityManager(new IdentityDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BirthCertificateQuery(string id)
        {
            var result = key.GetAll();

            if (!string.IsNullOrEmpty(id))
            {

                return View();
            }
            return View(result);
        }

        public ActionResult BirthCertificateGetList(int id)
        {

            //var birthCertificateGetList = manager.GetAllByIdentityId(id);
            //return View("BirthCertificateGetList", birthCertificateGetList);
            return View();
        }

        public ActionResult BirthCertificateGet(int id)
        {
            //var birthCertificateGet = manager.GetById(id);
            return View();
            //return View("BirthCertificateGet", birthCertificateGet);
        }


        [HttpGet]
        public ActionResult BirthCertificateUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult BirthCertificateUpdate(BirthCertificate birthCertificate)

        {
            manager.Update(birthCertificate);
            return RedirectToAction("");
        }
    }
}