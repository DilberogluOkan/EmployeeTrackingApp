using Business.Abstract;
using Business.Abstract.Dynamic;
using Business.Concrete;
using Business.Factory;
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
    public class IdentityController : Controller
    {
        IIdentityService _ıdentityService;
        IWorkplaceService _workplaceService;
        IGenderService _genderService;
        IMaritalStatusService _maritalStatusService;
        IDisabilityStatusService _disabilityStatusService;
        IBloodGroupService _bloodGroupService;
        IServiceInfoService _serviceInfoService;
        ICurrentStatusService _currentStatusService;
        IShiftInfoService _shiftInfoService;
        IWorkingStatusService _workingStatusService;
        IAdminStatusService _adminStatusService;
        IProvinceService _provinceService;
        ITisJobCodeService _tisJobCodeService;
        IPrivateStatusService _privateStatusService;

        public IdentityController(IIdentityService ıdentityService, IWorkplaceService workplaceService,
            IMaritalStatusService maritalStatusService, IGenderService genderService, IDisabilityStatusService disabilityStatusService,
            IBloodGroupService bloodGroupService, IServiceInfoService serviceInfoService, ICurrentStatusService currentStatusService,
            IWorkingStatusService workingStatusService, IShiftInfoService shiftInfoService, IAdminStatusService adminStatusService, IProvinceService provinceService, ITisJobCodeService tisJobCodeService, IPrivateStatusService privateStatusService)
        {
            _ıdentityService = ıdentityService;
            _workplaceService = workplaceService;
            _maritalStatusService = maritalStatusService;
            _genderService = genderService;
            _disabilityStatusService = disabilityStatusService;
            _bloodGroupService = bloodGroupService;
            _serviceInfoService = serviceInfoService;
            _currentStatusService = currentStatusService;
            _workingStatusService = workingStatusService;
            _shiftInfoService = shiftInfoService;
            _adminStatusService = adminStatusService;
            _provinceService = provinceService;
            _tisJobCodeService = tisJobCodeService;
            _privateStatusService = privateStatusService;
        }




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

       
        public ActionResult IdentityGet(int id)
        {
            DropList();
            var ıdentityGet = _ıdentityService.GetById(id).Data;
            return View("IdentityGet", ıdentityGet);
           
        }

        [HttpGet]
        public ActionResult IdentityUpdate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult IdentityUpdate(Identity ıdentity)

        {
            _ıdentityService.Update(ıdentity);
            return RedirectToAction("");
            
        }

        [HttpGet]
        public ActionResult IdentityUpdateLaterDesignation(IdentityInfoDto d)
        {
            var result = _ıdentityService.GetById(d.PersonelKimlikId).Data;
            var workPlaceGrp = _workplaceService.GetAll().Data.ToList();

            ViewBag.WorkPlaceGrpList = new SelectList(workPlaceGrp, "IsYeriId", "IsYeriAdi");
            return View("IdentityUpdateLaterDesignation", result);
            
        }
        [HttpPost]
        public ActionResult IdentityUpdateLaterDesignation(Identity ıdentity)
        {
            _ıdentityService.Update(ıdentity);
            return RedirectToAction("Index","Designation");
            
        }
         
        private void DropList()
        {
            var genderGrp = _genderService.GetAll().Data.ToList();
            var bloodGrp = _bloodGroupService.GetAll().Data.ToList();
            var maritalGrp = _maritalStatusService.GetAll().Data.ToList();
            var disabilityGrp = _privateStatusService.GetAll().Data.ToList();
            var serviceGrp = _serviceInfoService.GetAll().Data.ToList();
            var currentGrp = _currentStatusService.GetAll().Data.ToList();
            var workingStatusGrp = _workingStatusService.GetAll().Data.ToList();
            var shiftInfoGrp = _shiftInfoService.GetAll().Data.ToList();
            var workPlaceGrp = _workplaceService.GetAll().Data.ToList();
            var adminStatusGrp = _adminStatusService.GetAll().Data.ToList();
            var provinceGrp = _provinceService.GetAll().Data.ToList();
            var tisJobGrp = _tisJobCodeService.GetAll().Data.ToList();
            ViewBag.AdminStatusGrpList = new SelectList(adminStatusGrp, "IdarecilikDurumId", "IdarecilikDurumu");
            ViewBag.WorkPlaceGrpList = new SelectList(workPlaceGrp, "IsYeriId", "IsYeriAdi");
            ViewBag.GenderGrpList = new SelectList(genderGrp, "CinsiyetId", "Cinsiyeti");
            ViewBag.BloodGrpList = new SelectList(bloodGrp, "KanGrupId", "KanGrubu");
            ViewBag.MaritalStatusGrpList = new SelectList(maritalGrp, "MedeniHalId", "MedeniHali");
            ViewBag.DisabilityStatusGrpList = new SelectList(disabilityGrp, "OzelDurumId", "OzelDurumu");
            ViewBag.ServiceStatusGrpList = new SelectList(serviceGrp, "ServisBilgiId", "ServisBilgisi");
            ViewBag.CurrentStatusGrpList = new SelectList(currentGrp, "MevcutStatuId", "MevcutStatu");
            ViewBag.WorkingStatusGrpList = new SelectList(workingStatusGrp, "IstihtamDurumId", "IstihtamDurumu");
            ViewBag.ShiftInfoGrpList = new SelectList(shiftInfoGrp, "VardiyaBilgiId", "VardiyaBilgisi");
            ViewBag.ProvinceGrpList = new SelectList(provinceGrp, "IlId", "IlAdi");
            ViewBag.TisJobGrpList = new SelectList(tisJobGrp, "TisMeslekKodId", "TisMeslekAdi");
        }
    }
}