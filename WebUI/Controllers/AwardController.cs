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
    public class AwardController : Controller
    {
       
       
        IIdentityService _identityService;
        IAwardService _awardService;
        public AwardController(IIdentityService identityService, IAwardService awardService)
        {
            _identityService = identityService;
            _awardService = awardService;
        }

        // GET: Award
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

        public ActionResult AwardGetList(int id)
        {

            var awardGetList = _awardService.GetAllByIdentityId(id).Data;
            ViewBag.PersonelKimlikId = id;
            return View("AwardGetList", awardGetList);
        }

        public ActionResult AwardGet(int id)
        {
            var awardGet = _awardService.GetById(id).Data;

            return View("AwardGet", awardGet);
        }


        [HttpGet]
        public ActionResult AwardUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AwardUpdate(Award award)

        {
            _awardService.Update(award);
            return RedirectToAction("");
        }
        [HttpGet]
        public ActionResult AwardAdd(int id)
        {
            ViewBag.PersonelKimlikId = id;
            return View();
        }


        [HttpPost]
        public ActionResult AwardAdd(Award award)

        {
            _awardService.Add(award);
            return RedirectToAction("");
        }
    }
}