using Business.Abstract;
using Business.Abstract.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Factory
{
    public interface IServiceFactory
    {
        IIdentityService CreateIdentityService();
        void Release(IIdentityService ıdentityService);

        IWorkplaceService CreateWorkplaceService();
        void Release(IWorkplaceService workplaceService);

        IGenderService CreateGenderService();
        void Release(IGenderService genderService);

        IMaritalStatusService CreateMaritalStatusService();
        void Release(IMaritalStatusService maritalStatusService);

        IDisabilityStatusService CreateDisabilityStatusService();
        void Release(IDisabilityStatusService disabilityStatusService);

        IBloodGroupService CreateBloodGroupService();
        void Release(IBloodGroupService bloodGroupService);

        IServiceInfoService CreateServiceInfoService();
        void Release(IServiceInfoService serviceInfoService);

        ICurrentStatusService CreateCurrentStatusService();
        void Release(ICurrentStatusService currentStatusService);

        IShiftInfoService CreateShiftInfoService();
        void Release(IShiftInfoService shiftInfoService);

        IWorkingStatusService CreateWorkingStatusService();
        void Release(IWorkingStatusService workingStatusService);

        IAdminStatusService CreateAdminStatusService();
        void Release(IAdminStatusService adminStatusService);

        IProvinceService CreateProvinceService();
        void Release(IProvinceService provinceService);

        ITisJobCodeService CreateTisJobCodeService();
        void Release(ITisJobCodeService tisJobCodeService);

        IPrivateStatusService CreatePrivateStatusService();
        void Release(IPrivateStatusService privateStatusService);







    }
}
