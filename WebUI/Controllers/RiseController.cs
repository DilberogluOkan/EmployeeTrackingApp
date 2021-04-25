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
    public class RiseController : Controller
    {
      
        IPromotionService _promotionService;
        IIdentityService _ıdentityService;

        public RiseController(IPromotionService promotionService, IIdentityService ıdentityService)
        {
            _promotionService = promotionService;
            _ıdentityService = ıdentityService;
        }

        // GET: Rise
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IndexQuery(string tcNo)
        {
            var result = _ıdentityService.GetPersonDetails(tcNo).Data;
            return View(result);
        }

        public ActionResult RiseGetList(int id)
        {

            var riseGetList = _promotionService.GetAllByIdentityId(id).Data;
            return View("RiseGetList", riseGetList);
        }

        public ActionResult RiseGet(int id)
        {
            var riseGet = _promotionService.GetById(id).Data;

            return View("RiseGet", riseGet);
        }


        [HttpGet]
        public ActionResult RiseUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult RiseUpdate(Promotion promotion)

        {
            _promotionService.Update(promotion);
            return RedirectToAction("");
        }
        [HttpGet]
        public ActionResult RiseAdd()
        {
            return View();
        }


        [HttpPost]
        public ActionResult RiseAdd(Promotion promotion)

        {
            _promotionService.Add(promotion);
            return RedirectToAction("");
        }
    }
}