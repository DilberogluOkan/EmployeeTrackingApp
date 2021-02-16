using Business.Concrete;
using DataAccess.Concrete;
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
       
        public ActionResult Index(int identityId)
        {
            //var result = manager.GetById(identityId).Data;
            return View();
        }
    }
}