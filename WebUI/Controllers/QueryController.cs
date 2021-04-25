using Business.Abstract;
using Business.Abstract.Dynamic;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class QueryController : Controller
    {

        IAdaptationService _adaptationService;
        IGraduationService _graduationService;
        IIdentityService _ıdentityService;
        IAwardService _awardService;
        IBirthCertificateService _birthCertificateService;
        ICourseService _courseService;
        ICriminalService _criminalService;
        IDesignationService _designationService;
        IPermissionService _permissionService;
        IPromotionService _promotionService;
        ITemporaryDutyService _temporaryDutyService;
        IForeignLanguageService _foreignLanguageService;
        IWorkingPriceService _workingPriceService;
        ITradeUnionInfoService _tradeUnionInfoService;
        IMilitaryService _militaryService;
        IWorkplaceService _workplaceService;




        public QueryController(IAdaptationService adaptationService, IGraduationService graduationService,
            IIdentityService ıdentityService, IAwardService awardService, IBirthCertificateService birthCertificateService,
            ICourseService courseService, ICriminalService criminalService, IDesignationService designationService,
            IPermissionService permissionService, IPromotionService promotionService, ITemporaryDutyService temporaryDutyService,
            IForeignLanguageService foreignLanguageService, IWorkingPriceService workingPriceService, ITradeUnionInfoService tradeUnionInfoService, IMilitaryService militaryService, IWorkplaceService workplaceService)
        {
            _adaptationService = adaptationService;
            _graduationService = graduationService;
            _ıdentityService = ıdentityService;
            _awardService = awardService;
            _birthCertificateService = birthCertificateService;
            _courseService = courseService;
            _criminalService = criminalService;
            _designationService = designationService;
            _permissionService = permissionService;
            _promotionService = promotionService;
            _temporaryDutyService = temporaryDutyService;
            _foreignLanguageService = foreignLanguageService;
            _workingPriceService = workingPriceService;
            _tradeUnionInfoService = tradeUnionInfoService;
            _militaryService = militaryService;
            _workplaceService = workplaceService;
        }


        [HttpPost]
        public ActionResult IndexQuery(string tcNo)
        {
            var result = _ıdentityService.GetPersonDetails(tcNo).Data;
            return View(result);
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ReportBuid(int id)
        {
           
            MultiModelReportDto multi = new MultiModelReportDto();

            multi.PriceDto= _workingPriceService.GetPriceDetails(id).Data.ToList();
            multi.DesignationDto = _designationService.GetDesignationDetails(id).Data.ToList();
            multi.PermissionDto = _permissionService.GetPermissionDetails(id).Data.ToList();
            multi.TemporaryDutyDto = _temporaryDutyService.GetTemporaryDutyDetails(id).Data.ToList();
            multi.CriminalDto = _criminalService.GetCriminalDetails(id).Data.ToList();
            multi.PromotionDto = _promotionService.GetPromotionDetails(id).Data.ToList();
            multi.GraduationDto = _graduationService.GetGraduationDetails(id).Data.ToList();
            multi.PersonWorkplaceDto = _ıdentityService.GetPersonWorkplaceDtoDetails(id).Data.ToList();
            multi.PersonGeneralDto = _ıdentityService.GetPersonGeneralDetails(id).Data.ToList();
            multi.PersonIndividualDto = _ıdentityService.GetPersonIndividualDtoDetails(id).Data.ToList();
            multi.PersonTradeUnionInfoDto = _ıdentityService.GetPersonTradeUnionInfoDtoDetails(id).Data.ToList();
            multi.Award = _awardService.GetAllByIdentityId(id).Data.ToList();
            multi.Adaptation = _adaptationService.GetAllByIdentityId(id).Data.ToList();
            multi.ForeignLanguageDto = _foreignLanguageService.GetForeignLanguageDetails(id).Data.ToList();
            multi.Course = _courseService.GetAllByIdentityId(id).Data.ToList();
            multi.Military = _militaryService.GetAllById(id).Data.ToList();

            return View(multi);
        }

        public ActionResult Inspection()
        {
           
            var workplace = _workplaceService.GetAll().Data.ToList();
            int count = workplace.Count();
            InspectionCountMethod(count);
            return View(workplace);
        }
        public ActionResult InspectionPdf()
        {
            var workplace = _workplaceService.GetAll().Data.ToList();
            int count = workplace.Count();
            InspectionCountMethod(count);
            return View(workplace);
        }
        private void InspectionCountMethod(int count)
        {
            List<int> WorkplaceCountList = new List<int>();
            int sumPerson = 0;
            for (int i = 1; i <= count; i++)
            {
                var workplaceCount = _ıdentityService.WorkplaceCount(i).Data.Count();
                sumPerson = workplaceCount + sumPerson;
                WorkplaceCountList.Add(workplaceCount);
            }
            ViewBag.sayi = WorkplaceCountList.ToList();
            ViewBag.SumPerson = sumPerson;
        }


    }
        
}

