using Core.Entities;
using Entities.Concrete;
using Entities.Concrete.DynamicDataEntity;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class MultiModelReportDto:IDto
    {
       
        public List<Adaptation> Adaptation { get; set; }
        public List<Award> Award { get; set; }
        public List<Course> Course { get; set; }
        public List<ForeignLanguageDto> ForeignLanguageDto { get; set; }
        public List<PriceDto>PriceDto { get; set; }
        public List<DesignationDto> DesignationDto { get; set; }
        public List<PermissionDto> PermissionDto { get; set; }
        public List<TemporaryDutyDto> TemporaryDutyDto { get; set; }
        public List<CriminalDto> CriminalDto { get; set; }
        public List<PromotionDto> PromotionDto { get; set; }
        public List<GraduationDto> GraduationDto { get; set; }
        public List<PersonWorkplaceDto> PersonWorkplaceDto { get; set; }
        public List<PersonGeneralDto> PersonGeneralDto { get; set; }
        public List<PersonIndividualDto> PersonIndividualDto { get; set; }
        public List<PersonTradeUnionInfoDto> PersonTradeUnionInfoDto { get; set; }
        public List<Military> Military { get; set; }

    }
}
