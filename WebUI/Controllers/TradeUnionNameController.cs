using Business.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class TradeUnionNameController : Controller
    {
        ITradeUnionNameService _tradeUnionNameService;

        public TradeUnionNameController(ITradeUnionNameService tradeUnionNameService)
        {
            _tradeUnionNameService = tradeUnionNameService;
        }

        // GET: TradeUnionName
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TradeUnionNameGetAll()
        {
            var result = _tradeUnionNameService.GetAll().Data.ToList();
            return View("TradeUnionNameGetAll", result);
        }
        public ActionResult TradeUnionNameGetById(int id)
        {
            var result = _tradeUnionNameService.GetById(id).Data;
            return View("TradeUnionNameGetById", result);

        }

        [HttpGet]
        public ActionResult TradeUnionNameAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TradeUnionNameAdd(TradeUnionName tradeUnionName)
        {
            _tradeUnionNameService.Add(tradeUnionName);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult TradeUnionNameUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult TradeUnionNameUpdate(TradeUnionName tradeUnionName)
        {
            _tradeUnionNameService.Update(tradeUnionName);
            return RedirectToAction("");
        }

        [HttpGet]
        public ActionResult TradeUnionNameDelete()
        {

            return View();
        }

        [HttpPost]
        public ActionResult TradeUnionNameDelete(TradeUnionName tradeUnionName)
        {
            _tradeUnionNameService.Delete(tradeUnionName);
            return RedirectToAction("");
        }
    }
}