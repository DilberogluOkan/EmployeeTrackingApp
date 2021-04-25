using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class ForeignLanguageController : Controller
    {
        IForeignLanguageService _foreignLanguageService;
        IIdentityService _ıdentityService;
        ILanguageNameService _languageNameService;

        public ForeignLanguageController(IForeignLanguageService foreignLanguageService, IIdentityService ıdentityService, ILanguageNameService languageNameService)
        {
            _foreignLanguageService = foreignLanguageService;
            _ıdentityService = ıdentityService;
            _languageNameService = languageNameService;
        }

        // GET: ForeignLanguage
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

        public ActionResult ForeignLanguageGetList(int id)
        {

            var foreignLanguageGetList = _foreignLanguageService.GetForeignLanguageDetails(id).Data;
            ViewBag.PersonelKimlikId = id;
            return View("ForeignLanguageGetList", foreignLanguageGetList);
        }

        public ActionResult ForeignLanguageGet(int id)
        {
            DropBoxItem();
            var foreignLanguageGet = _foreignLanguageService.GetById(id).Data;
            return View("ForeignLanguageGet", foreignLanguageGet);
        }


        [HttpGet]
        public ActionResult ForeignLanguageUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult ForeignLanguageUpdate(ForeignLanguage foreignLanguage)

        {
            _foreignLanguageService.Update(foreignLanguage);
            return RedirectToAction("");
        }


        [HttpGet]
        public ActionResult ForeignLanguageGetAdd(int id)
        {
            DropBoxItem();
            ViewBag.PersonelKimlikId = id;
            return View();
           
        }

        [HttpGet]
        public ActionResult ForeignLanguageAdd()
        {
           
            return View();

        }

        [HttpPost]
        public ActionResult ForeignLanguageGetAdd(ForeignLanguage foreignLanguage)

        {
            _foreignLanguageService.Add(foreignLanguage);
            return RedirectToAction("");
        }

        private void DropBoxItem()
        {
            var languageNameGrp = _languageNameService.GetAll().Data.ToList();
            ViewBag.LanguageNameGrpList = new SelectList(languageNameGrp, "YabanciDilId", "YabanciDil");
        }
    }
}