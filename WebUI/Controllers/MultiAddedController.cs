using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class MultiAddedController : Controller
    {
        private BloodGroupManager _bloodGroup;
        private GenderManager _genderManager;
        private MaritalStatusManager _maritalStatusManager;

        public MultiAddedController(BloodGroupManager bloodGroupManager, GenderManager genderManager,
                                                            MaritalStatusManager maritalStatusManager)
        {
            _bloodGroup = bloodGroupManager;
            _genderManager = genderManager;//czxcz
            _maritalStatusManager = maritalStatusManager;
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Added()
        {
            var bloodGrp = _bloodGroup.GetAll().Data.ToList();
            var gender = _genderManager.GetAll().Data.ToList();
            var maritalStatus = _maritalStatusManager.GetAll().Data.ToList();

            ViewBag.BloodGrpList = new SelectList(bloodGrp, "KanGrupId", "KanGrubu");
            ViewBag.GenderList = new SelectList(gender, "CinsiyetId", "Cinsiyeti");
            ViewBag.MaritalStatusList = new SelectList(maritalStatus, "MedeniHalId", "MedeniHali");
            return View();
        }
        [HttpPost]
        public ActionResult Added(int i)
        {
            return View();
        }
    }
}