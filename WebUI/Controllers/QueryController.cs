using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class QueryController : Controller
    {
        AdaptationManager adaptation = new AdaptationManager(new AdaptationDal());
        GraduationManager manager = new GraduationManager(new GraduationDal());
        IdentityManager key = new IdentityManager(new IdentityDal());
        AwardManager award = new AwardManager(new AwardDal());
        BirthCertificateManager birth = new BirthCertificateManager(new BirthCertificateDal());
        CourseManager course = new CourseManager(new CourseDal());
        CriminalManager criminal = new CriminalManager(new CriminalDal());
        DesignationManager designation = new DesignationManager(new DesignationDal());
        PermissionManager permission = new PermissionManager(new PermissionDal());
        PromotionManager promotion = new PromotionManager(new PromotionDal());
        TemporaryDutyManager temporary = new TemporaryDutyManager(new TemporaryDutyDal());
        
        
        [HttpPost]
        public ActionResult IndexQuery(string tcNo)
        {
            var result = key.GetBytc(tcNo).Data;
            return View(result);
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ReportBuid(int id)
        {
            EmployeeContext c = new EmployeeContext();
            MultiModelReportDto multi = new MultiModelReportDto();

            multi.Identity = c.Identities.Where(p => p.PersonelKimlikId == id).ToList();

            multi.Graduation = manager.GetAllByIdentityId(id).Data.ToList();
            multi.Award = award.GetAllByIdentityId(id).Data.ToList();
            var result = key.GetById(id);
            multi.Course = course.GetAllByIdentityId(id).Data.ToList();
            multi.Criminal = criminal.GetAllByIdentityId(id).Data.ToList();
            multi.Designation = designation.GetAllByIdentityId(id).Data.ToList();
            multi.Adaptation = adaptation.GetAllByIdentityId(id).Data.ToList();
            multi.Permission = permission.GetAllByIdentityId(id).Data.ToList();
            multi.Promotion = promotion.GetAllByIdentityId(id).Data.ToList();
            multi.TemporaryDuty = temporary.GetAllByIdentityId(id).Data.ToList();
            //multi.Graduation = c.Graduations.Where(p => p.PersonelKimlikId == id).ToList();
            return View(multi);
        }
    }
}