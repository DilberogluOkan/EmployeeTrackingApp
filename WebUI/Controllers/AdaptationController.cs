using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class AdaptationController : Controller
    {
        AdaptationManager manager = new AdaptationManager(new AdaptationDal());

        public ActionResult Index(int identityId)
        {
            var result = manager.GetById(identityId).Data;
            return View(result);
        }
    }
}