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

        [HttpPost]
        public ActionResult IndexQuery(string tcNo)
        {
            var result = key.GetBytc(tcNo).Data;
            return View(result);
        }

        

        public ActionResult BirthCertificateGet(int id)
        {
            var birthCertificateGet = manager.GetById(id).Data;
            return View("BirthCertificateGet", birthCertificateGet);
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