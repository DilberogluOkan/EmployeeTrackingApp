using Business.Abstract;
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
      
        IBirthCertificateService _birthCertificateService;
        IIdentityService _identityService;

        public BirthCertificateController(IIdentityService identityService, IBirthCertificateService birthCertificateService)
        {
            _identityService = identityService;
            _birthCertificateService = birthCertificateService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IndexQuery(string tcNo)
        {
            var result = _identityService.GetPersonDetails(tcNo).Data;
            return View(result);
        }

        

        public ActionResult BirthCertificateGet(int id)
        {
            var birthCertificateGet = _birthCertificateService.GetById(id).Data;
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
            _birthCertificateService.Update(birthCertificate);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult BirthCertificateAdd()
        {
            return View();
        }


        [HttpPost]
        public ActionResult BirthCertificateAdd(BirthCertificate birthCertificate)

        {
            _birthCertificateService.Add(birthCertificate);
            return RedirectToAction("birthCertificateGetList");
        }
    }
}