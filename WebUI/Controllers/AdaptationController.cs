using Business.Abstract;
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
    public class AdaptationController : Controller
    {

        IIdentityService _identityService;
        IAdaptationService _adaptationService;

        public AdaptationController(IAdaptationService adaptationService, IIdentityService identityService)
        {
            _adaptationService = adaptationService;
            _identityService = identityService;
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
       

        public ActionResult AdaptationGetList(int id)
        {

            var adaptationGetList = _adaptationService.GetAllByIdentityId(id).Data;
            ViewBag.PersonelKimlikId = id;
            return View("AdaptationGetList", adaptationGetList);
        }

        public ActionResult AdaptationGet(int id)
        {
            var adaptationGet = _adaptationService.GetById(id).Data;

            return View("AdaptationGet", adaptationGet);
        }


        [HttpGet]
        public ActionResult AdaptationUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AdaptationUpdate(Adaptation adaptation)

        {
            _adaptationService.Update(adaptation);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult AdaptationAdd(int id)
        {
            var adaptationAdd = _adaptationService.GetById(id).Data;
            ViewBag.PersonelKimlikId = id;
            return View("AdaptationAdd", adaptationAdd);
        }


        [HttpPost]
        public ActionResult AdaptationAdd(Adaptation adaptation)

        {
            _adaptationService.Add(adaptation);
            return RedirectToAction("");
        }
    }
}