using Business.Abstract;
using Business.Abstract.Dynamic;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class MultiAddedController : Controller
    {

        IAdaptationService _adaptationService;
        IIdentityService _ıdentityService;
        IAwardService _awardService;
        IBloodGroupService _bloodGroupService;
        IGenderService _genderService;
        IMaritalStatusService _maritalStatusService;
        IDisabilityStatusService _disabilityStatusService;

        public MultiAddedController(IAdaptationService adaptationService, IIdentityService ıdentityService,
            IAwardService awardService, IBloodGroupService bloodGroupService, IGenderService genderService,
            IMaritalStatusService maritalStatusService, IDisabilityStatusService disabilityStatusService)
        {
            _adaptationService = adaptationService;
            _ıdentityService = ıdentityService;
            _awardService = awardService;
            _bloodGroupService = bloodGroupService;
            _genderService = genderService;
            _maritalStatusService = maritalStatusService;
            _disabilityStatusService = disabilityStatusService;
        }

        // GET: MultiAdded

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Added()
        {
            
            var bloodGrp = _bloodGroupService.GetAll().Data.ToList();
            var gender = _genderService.GetAll().Data.ToList();
            var maritalStatus = _maritalStatusService.GetAll().Data.ToList();
            var disabilityStatus = _disabilityStatusService.GetAll().Data.ToList();

            ViewBag.BloodGrpList = new SelectList(bloodGrp, "KanGrupId", "KanGrubu");
            ViewBag.GenderList = new SelectList(gender, "CinsiyetId", "Cinsiyeti");
            ViewBag.MaritalStatusList = new SelectList(maritalStatus, "MedeniHalId", "MedeniHali");
            ViewBag.DisabilityStatusList = new SelectList(disabilityStatus, "OzelDurumId", "OzelDurumu");
            return View();
        }
        [HttpPost]
        public ActionResult Added(MultiModelDto multi)
        {
            _ıdentityService.Add(multi.Identity);
            _adaptationService.Add(multi.Adaptation);
            _awardService.Add(multi.Award);
            return View();
        }
        
        
    }
}