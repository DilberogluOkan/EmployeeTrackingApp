using Autofac;
using Autofac.Integration.Mvc;
using Business.Abstract;
using Business.Abstract.Dynamic;
using Business.Concrete;
using Business.Concrete.Dynamic;
using DataAccess.Abstract;
using DataAccess.Abstract.Dynamic;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           
            ContainerBuilder builder = new ContainerBuilder();
           
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

           
            builder.RegisterType<AdaptationManager>().As<IAdaptationService>();
            builder.RegisterType<AdminStatusManager>().As<IAdminStatusService>();
            builder.RegisterType<AwardManager>().As<IAwardService>();
            builder.RegisterType<BirthCertificateManager>().As<IBirthCertificateService>();
            builder.RegisterType<BloodGroupManager>().As<IBloodGroupService>();
            builder.RegisterType<CourseManager>().As<ICourseService>();
            builder.RegisterType<CriminalManager>().As<ICriminalService>();
            builder.RegisterType<DailyWorkingTimeManager>().As<IDailyWorkingTimeService>();
            builder.RegisterType<DesignationManager>().As<IDesignationService>();
            builder.RegisterType<DisabilityStatusManager>().As<IDisabilityStatusService>();
            builder.RegisterType<ForeignLanguageManager>().As<IForeignLanguageService>();
            builder.RegisterType<GenderManager>().As<IGenderService>();
            builder.RegisterType<GraduationManager>().As<IGraduationService>();
            builder.RegisterType<GraduationStatusManager>().As<IGraduationStatusService>();
            builder.RegisterType<IdentityManager>().As<IIdentityService>();
            builder.RegisterType<MaritalStatusManager>().As<IMaritalStatusService>();
            builder.RegisterType<MilitaryManager>().As<IMilitaryService>();
            builder.RegisterType<PermissionManager>().As<IPermissionService>();
            builder.RegisterType<PriceGradeManager>().As<IPriceGradeService>();
            builder.RegisterType<PriceGradeRiseManager>().As<IPriceGradeRiseService>();
            builder.RegisterType<PriceTypeManager>().As<IPriceTypeService>();
            builder.RegisterType<PromotionManager>().As<IPromotionService>();
            builder.RegisterType<ServiceInfoManager>().As<IServiceInfoService>();
            builder.RegisterType<ShiftInfoManager>().As<IShiftInfoService>();
            builder.RegisterType<TemporaryDutyManager>().As<ITemporaryDutyService>();
            builder.RegisterType<WorkingPriceManager>().As<IWorkingPriceService>();
            builder.RegisterType<WorkingStatusManager>().As<IWorkingStatusService>();
            builder.RegisterType<WorkplaceManager>().As<IWorkplaceService>();
            builder.RegisterType<ReasonForPermissionManager>().As<IReasonForPermissionService>();
            builder.RegisterType<ReasonForDesignationManager>().As<IReasonForDesignationService>();
            builder.RegisterType<PermissionTypeManager>().As<IPermissionTypeService>();
            builder.RegisterType<ReasonForCriminalManager>().As<IReasonForCriminalService>();
            builder.RegisterType<TradeUnionInfoManager>().As<ITradeUnionInfoService>();
            builder.RegisterType<TradeUnionStatusManager>().As<ITradeUnionStatusService>();
            builder.RegisterType<TradeUnionNameManager>().As<ITradeUnionNameService>();
            builder.RegisterType<CurrentStatusManager>().As<ICurrentStatusService>();
            builder.RegisterType<ProvinceManager>().As<IProvinceService>();
            builder.RegisterType<PrivateStatusManager>().As<IPrivateStatusService>();
            builder.RegisterType<TisJobCodeManager>().As<ITisJobCodeService>();
            builder.RegisterType<SgkJobCodeManager>().As<ISgkJobCodeService>();
            builder.RegisterType<MilitaryStatusManager>().As<IMilitaryStatusService>();
            builder.RegisterType<DesignationStatusManager>().As<IDesignationStatusService>();
            builder.RegisterType<LanguageNameManager>().As<ILanguageNameService>();
            builder.RegisterType<DesignationApprovalManager>().As<IDesignationApprovalService>();
            builder.RegisterType<WorkplaceHeadquartersManager>().As<IWorkplaceHeadquartersService>();

            builder.RegisterType<AdaptationDal>().As<IAdaptationDal>();
            builder.RegisterType<AdminStatusDal>().As<IAdminStatusDal>();
            builder.RegisterType<AwardDal>().As<IAwardDal>();
            builder.RegisterType<BirthCertificateDal>().As<IBirthCertificateDal>();
            builder.RegisterType<BloodGroupDal>().As<IBloodGroupDal>();
            builder.RegisterType<CourseDal>().As<ICourseDal>();
            builder.RegisterType<CriminalDal>().As<ICriminalDal>();
            builder.RegisterType<DailyWorkingTimeDal>().As<IDailyWorkingTimeDal>();
            builder.RegisterType<DesignationDal>().As<IDesignationDal>();
            builder.RegisterType<DisabilityStatusDal>().As<IDisabilityStatusDal>();
            builder.RegisterType<ForeignLanguageDal>().As<IForeignLanguageDal>();
            builder.RegisterType<GenderDal>().As<IGenderDal>();
            builder.RegisterType<GraduationDal>().As<IGraduationDal>();
            builder.RegisterType<GraduationStatusDal>().As<IGraduationStatusDal>();
            builder.RegisterType<IdentityDal>().As<IIdentityDal>();
            builder.RegisterType<MaritalStatusDal>().As<IMaritalStatusDal>();
            builder.RegisterType<MilitaryDal>().As<IMilitaryDal>();
            builder.RegisterType<PermissionDal>().As<IPermissionDal>();
            builder.RegisterType<PriceGradeDal>().As<IPriceGradeDal>();
            builder.RegisterType<PriceGradeRiseDal>().As<IPriceGradeRiseDal>();
            builder.RegisterType<PriceTypeDal>().As<IPriceTypeDal>();
            builder.RegisterType<PromotionDal>().As<IPromotionDal>();
            builder.RegisterType<ServiceInfoDal>().As<IServiceInfoDal>();
            builder.RegisterType<ShiftInfoDal>().As<IShiftInfoDal>();
            builder.RegisterType<TemporaryDutyDal>().As<ITemporaryDutyDal>();
            builder.RegisterType<WorkingPriceDal>().As<IWorkingPriceDal>();
            builder.RegisterType<WorkingStatusDal>().As<IWorkingStatusDal>();
            builder.RegisterType<WorkplaceDal>().As<IWorkplaceDal>();
            builder.RegisterType<ReasonForPermissionDal>().As<IReasonForPermissionDal>();
            builder.RegisterType<ReasonForDesignationDal>().As<IReasonForDesignationDal>();
            builder.RegisterType<PermissionTypeDal>().As<IPermissionTypeDal>();
            builder.RegisterType<ReasonForCriminalDal>().As<IReasonForCriminalDal>();
            builder.RegisterType<TradeUnionInfoDal>().As<ITradeUnionInfoDal>();
            builder.RegisterType<TradeUnionStatusDal>().As<ITradeUnionStatusDal>();
            builder.RegisterType<TradeUnionNameDal>().As<ITradeUnionNameDal>();
            builder.RegisterType<CurrentStatusDal>().As<ICurrentStatusDal>();
            builder.RegisterType<ProvinceDal>().As<IProvinceDal>();
            builder.RegisterType<PrivateStatusDal>().As<IPrivateStatusDal>();
            builder.RegisterType<TisJobCodeDal>().As<ITisJobCodeDal>();
            builder.RegisterType<SgkJobCodeDal>().As<ISgkJobCodeDal>();
            builder.RegisterType<MilitaryStatusDal>().As<IMilitaryStatusDal>();
            builder.RegisterType<DesignationStatusDal>().As<IDesignationStatusDal>();
            builder.RegisterType<LanguageNameDal>().As<ILanguageNameDal>();
            builder.RegisterType<DesignationApprovalDal>().As<IDesignationApprovalDal>();
            builder.RegisterType<WorkplaceHeadquartersDal>().As<IWorkplaceHeadquartersDal>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
