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
    public class IdentityController : Controller
    {
       
        IdentityManager manager = new IdentityManager(new IdentityDal());
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
    }
}