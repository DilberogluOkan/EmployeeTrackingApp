using Business.Concrete;
using DataAccess.Concrete;
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
        // GET: Award
        public ActionResult Index(int identityId)
        {
            var result = manager.GetById(identityId).Data;
            return View(result);
        }
    }
}