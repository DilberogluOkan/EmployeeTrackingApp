using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class QueryController : Controller
    {
        IdentityManager manager = new IdentityManager(new IdentityDal());

        [HttpGet]
        public ActionResult Index(string tcNo)
        {
           
            var result = manager.GetAll().Data;
            if (!string.IsNullOrEmpty(tcNo))
            {
            }
            return View(result);
        }
        [HttpPost]
        public ActionResult Index(int identityId)
        {
            var result = manager.GetById(identityId).Data;
            return View(result);
        }
    }
}