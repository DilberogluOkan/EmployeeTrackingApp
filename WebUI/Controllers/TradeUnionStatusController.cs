using Business.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class TradeUnionStatusController : Controller
    {
        ITradeUnionStatusService _tradeUnionStatusService;
        
        public TradeUnionStatusController(ITradeUnionStatusService tradeUnionStatusService)
        {
            _tradeUnionStatusService = tradeUnionStatusService;
        }

        // GET: TradeUnionStatus
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TradeUnionStatusGetAll()
        {
            var result = _tradeUnionStatusService.GetAll().Data.ToList();
            return View("TradeUnionStatusGetAll", result);
        }
        public ActionResult TradeUnionStatusGetById(int id)
        {
            var result = _tradeUnionStatusService.GetById(id).Data;
            return View("TradeUnionStatusGetById", result);

        }

        [HttpGet]
        public ActionResult TradeUnionStatusAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TradeUnionStatusAdd(TradeUnionStatus tradeUnionStatus)
        {
            _tradeUnionStatusService.Add(tradeUnionStatus);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult TradeUnionStatusUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult TradeUnionStatusUpdate(TradeUnionStatus tradeUnionStatus)
        {
            _tradeUnionStatusService.Update(tradeUnionStatus);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult TradeUnionStatusDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult TradeUnionStatusDelete(TradeUnionStatus tradeUnionStatus)
        {
            _tradeUnionStatusService.Delete(tradeUnionStatus);
            return RedirectToAction("");
        }
    }
}