using Business.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class ReasonForPromotionController : Controller
    {
        IReasonForPromotionService _reasonForPromotionService;

        public ReasonForPromotionController(IReasonForPromotionService reasonForPromotionService)
        {
            _reasonForPromotionService = reasonForPromotionService;
        }

        // GET: ReasonForPromotion
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ReasonForPromotionGetAll()
        {
            var result = _reasonForPromotionService.GetAll().Data.ToList();
            return View("ReasonForPromotionGetAll", result);
        }
        public ActionResult ReasonForPromotionGetById(int id)
        {
            var result = _reasonForPromotionService.GetById(id).Data;
            return View("ReasonForPromotionGetById", result);

        }

        [HttpGet]
        public ActionResult ReasonForPromotionAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult ReasonForPromotionAdd(ReasonForPromotion reasonForPromotion)
        {
            _reasonForPromotionService.Add(reasonForPromotion);
            return RedirectToAction("ReasonForPromotionGetAll");
        }

        [HttpGet]
        public ActionResult ReasonForPromotionUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ReasonForPromotionUpdate(ReasonForPromotion reasonForPromotion)
        {
            _reasonForPromotionService.Update(reasonForPromotion);
            return RedirectToAction("ReasonForPromotionGetAll");
        }

        [HttpGet]
        public ActionResult ReasonForPromotionDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ReasonForPromotionDelete(ReasonForPromotion reasonForPromotion)
        {
            _reasonForPromotionService.Delete(reasonForPromotion);
            return RedirectToAction("ReasonForPromotionGetAll");
        }
    }
}