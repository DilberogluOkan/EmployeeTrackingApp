using Business.Abstract;
using Business.Abstract.Dynamic;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.DynamicDataEntity;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class DesignationController : Controller
    {

        IDesignationService _designationService;
        IIdentityService _ıdentityService;
        IReasonForDesignationService _reasonForDesignationService;
        IWorkplaceService _workplaceService;
        IDesignationStatusService _designationStatusService;
        IDesignationApprovalService _designationApprovalService;



        public DesignationController(IIdentityService ıdentityService, IDesignationService designationService,
            IReasonForDesignationService reasonForDesignationService, IWorkplaceService workplaceService, IDesignationStatusService designationStatusService, IDesignationApprovalService designationApprovalService)
        {
            _ıdentityService = ıdentityService;
            _designationService = designationService;
            _reasonForDesignationService = reasonForDesignationService;
            _workplaceService = workplaceService;
            _designationStatusService = designationStatusService;
            _designationApprovalService = designationApprovalService;
        }

        // GET: Designation
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

        public ActionResult DesignationGetList(int id)
        {
            var designationGetList = _designationService.GetDesignationDetails(id).Data.ToList();
           
            ViewBag.PersonelKimlikId = id;
            
            return View("DesignationGetList", designationGetList);
        }

        public ActionResult DesignationGet(int id)
        {
            DropBoxItem();
            var designationGet = _designationService.GetById(id).Data;
            return View("DesignationGet", designationGet);
        }


        [HttpGet]
        public ActionResult DesignationUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult DesignationUpdate(Designation designation)

        {
            _designationService.Update(designation);
            return RedirectToAction("");
        }
      
        public ActionResult DesignationGetAdd(int id)
        {
            DropBoxItem();
            ViewBag.PersonelKimlikId = id;
            return View();
        }

        [HttpGet]
        public ActionResult DesignationAdd()
        {
            return View();
        }


        [HttpPost]
        public ActionResult DesignationAdd(Designation designation,IdentityInfoDto ıdentityInfo)
        {
            _designationService.Add(designation);
            return RedirectToAction("IdentityUpdateLaterDesignation", "Identity", ıdentityInfo);
        }

       
        public ActionResult DesignationPdf(int id)
        {
            MultiModelReportDto multiPdf = new MultiModelReportDto();
            multiPdf.PersonGeneralDto = _ıdentityService.GetPersonGeneralDetails(id).Data.ToList();
            multiPdf.DesignationDto = _designationService.GetDesignationDetails(id).Data.ToList();
            return View(multiPdf);
        }



        private void DropBoxItem()
        {
            var workPlaceGrp = _workplaceService.GetAll().Data.ToList();
            var designationStatusGrp = _designationStatusService.GetAll().Data.ToList();
            var reasonForDesignationGrp = _reasonForDesignationService.GetAll().Data.ToList();
            var designationApprovalGrp = _designationApprovalService.GetAll().Data.ToList();

            ViewBag.DesignationApprovalGrpList = new SelectList(designationApprovalGrp, "OnayId", "OnayDurumValue");
            ViewBag.WorkPlaceGrpList = new SelectList(workPlaceGrp, "IsYeriId", "Birimi");
            ViewBag.DesignationStatusGrpList = new SelectList(designationStatusGrp, "NakilDurumId", "NakilDurumu");
            ViewBag.ReasonForDesignationGrpList = new SelectList(reasonForDesignationGrp, "AtamaIstegiNedenId", "AtamaIstegiNedeni");
           
        }
    }
}