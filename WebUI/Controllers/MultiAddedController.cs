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
    public class MultiAddedController : Controller
    {
        AdaptationManager manager = new AdaptationManager(new AdaptationDal());
        IdentityManager key = new IdentityManager(new IdentityDal());
        AwardManager award = new AwardManager(new AwardDal());

        BloodGroupManager _bloodGroup = new BloodGroupManager(new BloodGroupDal());
        GenderManager _genderManager= new GenderManager(new GenderDal());
        MaritalStatusManager _maritalStatusManager= new MaritalStatusManager(new MaritalStatusDal());
        DisabilityStatusManager _disabilityStatusManager= new DisabilityStatusManager(new DisabilityStatusDal());
        // GET: MultiAdded
       
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
            var disabilityStatus = _disabilityStatusManager.GetAll().Data.ToList();

            ViewBag.BloodGrpList = new SelectList(bloodGrp, "KanGrupId", "KanGrubu");
            ViewBag.GenderList = new SelectList(gender, "CinsiyetId", "Cinsiyeti");
            ViewBag.MaritalStatusList = new SelectList(maritalStatus, "MedeniHalId", "MedeniHali");
            ViewBag.DisabilityStatusList = new SelectList(disabilityStatus, "OzelDurumId", "OzelDurumu");
            return View();
        }
        [HttpPost]
        public ActionResult Added(MultiModelDto multi)
        {
            key.Add(multi.Identity);
            manager.Add(multi.Adaptation);
            
            award.Add(multi.Award);
            return View();
        }
        
        
    }
}