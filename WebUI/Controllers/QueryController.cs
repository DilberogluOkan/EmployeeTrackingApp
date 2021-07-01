using Business.Abstract;
using Business.Abstract.Dynamic;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        IPriceTypeService _priceTypeService;
        ITisJobCodeService _tisJobCodeService;
        IAdminStatusService _adminStatusService;
        IDailyWorkingTimeService _dailyWorkingTimeService;
        IPrivateStatusService _privateStatusService;
        IMaritalStatusService _maritalStatusService;
        IGenderService _genderService;
        IWorkingStatusService _workingStatusService;
        IWorkplaceHeadquartersService _workplaceHeadquartersService;
        public QueryController(IAdaptationService adaptationService, IGraduationService graduationService,
            IIdentityService ıdentityService, IAwardService awardService, IBirthCertificateService birthCertificateService,
            ICourseService courseService, ICriminalService criminalService, IDesignationService designationService,
            IPermissionService permissionService, IPromotionService promotionService, ITemporaryDutyService temporaryDutyService,
            IForeignLanguageService foreignLanguageService, IWorkingPriceService workingPriceService, ITradeUnionInfoService tradeUnionInfoService,
            IMilitaryService militaryService, IWorkplaceService workplaceService, IPriceTypeService priceTypeService, ITisJobCodeService tisJobCodeService,
            IAdminStatusService adminStatusService, IDailyWorkingTimeService dailyWorkingTimeService, IPrivateStatusService privateStatusService, IMaritalStatusService maritalStatusService, IGenderService genderService, IWorkingStatusService workingStatusService, IWorkplaceHeadquartersService workplaceHeadquartersService)
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
            _priceTypeService = priceTypeService;
            _tisJobCodeService = tisJobCodeService;
            _adminStatusService = adminStatusService;
            _dailyWorkingTimeService = dailyWorkingTimeService;
            _privateStatusService = privateStatusService;
            _maritalStatusService = maritalStatusService;
            _genderService = genderService;
            _workingStatusService = workingStatusService;
            _workplaceHeadquartersService = workplaceHeadquartersService;
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
        
        public ActionResult InspectionWorkplace()
        {
            var workplace = _workplaceService.GetAll().Data.ToList();
            int count = workplace.Count();
            InspectionCountMethod(count);
            return View(workplace);
        }

        public ActionResult InspectionHeadquarters()
        {
            WorkplaceCardCounts();
            return View();
        }

        public ActionResult InspectionHeadquartersPdf()
        {
            WorkplaceCardCounts();
            return View();
        }

        public ActionResult InspectionWorkplacePdf()
        {
            var workplace = _workplaceService.GetAll().Data.ToList();
            int count = workplace.Count();
            List<int> WorkplaceCountList = new List<int>();
            int sumPerson = 0;
            for (int i = 1; i <= count; i++)
            {
                var workplaceCount = _ıdentityService.WorkplaceCount(i).Data.Count();
                sumPerson = workplaceCount + sumPerson;
                WorkplaceCountList.Add(workplaceCount);
            }
            ViewBag.Sayi = WorkplaceCountList.ToList();
            ViewBag.SumPerson = sumPerson;

            return View(workplace);
           
        }

        [HttpGet]
        public ActionResult FilterQuery()
        {
            DropBoxItem();
            return View();
        }
        
        public ActionResult FilterQueryPost(FilterQueryDto filterQueryDto,CheckDto checkDto)
        {

            if (checkDto.ExcelAktarımDurum=="true")
            {
                ExcelImportService(filterQueryDto);
            }
            
            var result = _ıdentityService.GetFilterQueryDetails(filterQueryDto).Data.ToList();
            ViewBag.PersonCount = result.Count();
            return View(Tuple.Create(result,checkDto));
        }
        

        public ActionResult FilterQueryAgePost(int YasBaslangic,int YasBitis)
        {
            var result = _ıdentityService.GetAllByAge(YasBaslangic,YasBitis).Data.ToList();
            ViewBag.AgeCount = result.Count();
            ViewBag.BaslangicYas = YasBaslangic;
            ViewBag.BitisYas = YasBitis;
            return View(result);
        }

        public void InspectionCountMethod(int count)
        {
            List<int> WorkplaceCountList = new List<int>();
            int sumPerson = 0;
            for (int i = 1; i <= count; i++)
            {
                var workplaceCount = _ıdentityService.WorkplaceCount(i).Data.Count();
                sumPerson = workplaceCount + sumPerson;
                WorkplaceCountList.Add(workplaceCount);
            }
            ViewBag.Sayi = WorkplaceCountList.ToList();
            ViewBag.SumPerson = sumPerson;

        }
        private void DropBoxItem()
        {
            var workplaceGrp = _workplaceService.GetAll().Data.ToList();
            var workplaceHeadquartersGrp = _workplaceHeadquartersService.GetAll().Data.ToList();
            var priceTypeGrp = _priceTypeService.GetAll().Data.ToList();
            var tisJobCodeGrp = _tisJobCodeService.GetAll().Data.ToList();
            var adminStatusGrp = _adminStatusService.GetAll().Data.ToList();
            var dailyWorkingTimeGrp = _dailyWorkingTimeService.GetAll().Data.ToList();
            var disabilityStatusGrp = _privateStatusService.GetAll().Data.ToList();
            var maritalStatusGrp = _maritalStatusService.GetAll().Data.ToList();
            var genderGrp = _genderService.GetAll().Data.ToList();
            var workingStatusGrp = _workingStatusService.GetAll().Data.ToList();

            ViewBag.WorkingStatusGrpList = new SelectList(workingStatusGrp, "IstihtamDurumId", "IstihtamDurumu");
            ViewBag.GenderGrpList = new SelectList(genderGrp,"CinsiyetId","Cinsiyeti");
            ViewBag.MaritalStatusGrpList = new SelectList(maritalStatusGrp, "MedeniHalId", "MedeniHali");
            ViewBag.DisabilityStatusGrpList = new SelectList(disabilityStatusGrp, "OzelDurumId", "OzelDurumu");
            ViewBag.DailyWorkingTimeGrpList = new SelectList(dailyWorkingTimeGrp, "GunlukCalismaSureId", "GunlukCalismaSuresi");
            ViewBag.AdminStatusGrpList = new SelectList(adminStatusGrp, "IdarecilikDurumId", "IdarecilikDurumu");
            ViewBag.PriceTypeGrpList = new SelectList(priceTypeGrp, "UcretTurId", "UcretTuru");
            ViewBag.TisJobCodeGrpList = new SelectList(tisJobCodeGrp, "TisMeslekKodId", "TisMeslekAdi");
            ViewBag.WorkplaceGrpList = new SelectList(workplaceGrp, "IsYeriId", "IsYeriAdi");
            ViewBag.WorkplaceHeadquartersGrpList = new SelectList(workplaceHeadquartersGrp, "GenelMudurlukId", "GenelMudurluk");
        }
        private void ExcelImportService(FilterQueryDto filterQueryDto)
        {
            var result = _ıdentityService.GetFilterQueryDetails(filterQueryDto).Data.ToList();

            try
            {
                ExcelPackage pck = new ExcelPackage();
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Report");
                ws.Cells["A6"].Value = "BİRİM";
                ws.Cells["B6"].Value = "KUVVET";
                ws.Cells["C6"].Value = "İŞ YERİ ";
                ws.Cells["D6"].Value = "TC";
                ws.Cells["E6"].Value = "AD";
                ws.Cells["F6"].Value = "SOYAD";
                ws.Cells["G6"].Value = "MEDENİ HAL";
                ws.Cells["H6"].Value = "CİNSİYET";
                ws.Cells["I6"].Value = "ÖZEL DURUM";
                ws.Cells["J6"].Value = "İSTİHTAM DURUMU";
                ws.Cells["K6"].Value = "DOĞUM TARİHİ";
                ws.Cells["L6"].Value = "MSB KATILIŞ TARİHİ";
                ws.Cells["M6"].Value = "İDARECİLİK DURUMU";
                ws.Cells["N6"].Value = "ÜCRET TÜRÜ";
                ws.Cells["O6"].Value = "GÜNLÜK ÇALIŞMA SÜRESİ";
                ws.Cells["P6"].Value = "MESLEK KOLU";
                int rowStart = 7;
                foreach (var item in result)
                {
                    ws.Cells[string.Format("A{0}", rowStart)].Value = item.Birimi;
                    ws.Cells[string.Format("B{0}", rowStart)].Value = item.Kuvvet;
                    ws.Cells[string.Format("C{0}", rowStart)].Value = item.IsYeriAdi;
                    ws.Cells[string.Format("D{0}", rowStart)].Value = item.TcNo;
                    ws.Cells[string.Format("E{0}", rowStart)].Value = item.Ad;
                    ws.Cells[string.Format("F{0}", rowStart)].Value = item.Soyad;
                    ws.Cells[string.Format("G{0}", rowStart)].Value = item.MedeniHali;
                    ws.Cells[string.Format("H{0}", rowStart)].Value = item.Cinsiyeti;
                    ws.Cells[string.Format("I{0}", rowStart)].Value = item.EngelDurumu;
                    ws.Cells[string.Format("J{0}", rowStart)].Value = item.IstihtamDurumu;
                    ws.Cells[string.Format("K{0}", rowStart)].Value = item.DogumTarihi;
                    ws.Cells[string.Format("L{0}", rowStart)].Value = item.KatilisTarihi;
                    ws.Cells[string.Format("M{0}", rowStart)].Value = item.IdarecilikDurumu;
                    ws.Cells[string.Format("N{0}", rowStart)].Value = item.UcretTuru;
                    ws.Cells[string.Format("O{0}", rowStart)].Value = item.GunlukCalismaSuresi;
                    ws.Cells[string.Format("P{0}", rowStart)].Value = item.MeslekKol;
                   

                    rowStart++;
                }
                ws.Cells["A6:O6"].Style.Font.Bold = true;
                ws.Cells["A:AZ"].AutoFitColumns();
                Response.Clear();
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", "attachment:filename" + "ExcelReport.xlsx");
                Response.BinaryWrite(pck.GetAsByteArray());
                Response.End();
            }
            catch (Exception)
            {
                ViewBag.Message = "Hata Oluştu Excel Dökümanı Oluşturulamadı!";
            }


        }


        public void ExcelImportInspectionHeadquartersService()
        {
            var afgmCount = _ıdentityService.AfgmForCount().Data.Count();
            var asalCount = _ıdentityService.AsalForCount().Data.Count();
            var asfatCount = _ıdentityService.AsfatForCount().Data.Count();
            var ashgmCount = _ıdentityService.AshgmForCount().Data.Count();
            var dzkkCount = _ıdentityService.DzkkForCount().Data.Count();
            var gnkurCount = _ıdentityService.GnkurForCount().Data.Count();
            var hgmCount = _ıdentityService.HgmForCount().Data.Count();
            var hvkkCount = _ıdentityService.HvkkForCount().Data.Count();
            var kkkCount = _ıdentityService.KkkForCount().Data.Count();
            var lgmCount = _ıdentityService.LgmForCount().Data.Count();
            var msuCount = _ıdentityService.MsuForCount().Data.Count();
            var tedgmCount = _ıdentityService.TedgmForCount().Data.Count();
            var tgmCount = _ıdentityService.TgmForCount().Data.Count();
            var yhgmCount = _ıdentityService.YhgmForCount().Data.Count();

            try
            {
                ExcelPackage pck = new ExcelPackage();
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Report");

                ws.Cells["A6"].Value = "Genel Müdürlükler";
                ws.Cells["B6"].Value = "KişiSayısı";
               
                ws.Cells[string.Format("A{0}", 7)].Value = "Tersaneler Genel Müdürlüğü";
                ws.Cells[string.Format("B{0}", 7)].Value = tgmCount;
                ws.Cells[string.Format("A{0}", 8)].Value = "Askeri Fabrikalar Genel Müdürlüğü";
                ws.Cells[string.Format("B{0}", 8)].Value = afgmCount;
                ws.Cells[string.Format("A{0}", 9)].Value = "Tedarik Hizmetleri Genel Müdürlüğü";
                ws.Cells[string.Format("B{0}", 9)].Value = tedgmCount;
                ws.Cells[string.Format("A{0}", 10)].Value = "	Yönetim Hizmetleri Genel Müdürlüğü";
                ws.Cells[string.Format("B{0}", 10)].Value = yhgmCount;
                ws.Cells[string.Format("A{0}", 11)].Value = "	Lojistik Genel Müdürlüğü";
                ws.Cells[string.Format("B{0}", 11)].Value = lgmCount;
                ws.Cells[string.Format("A{0}", 12)].Value = "	Harita Genel Müdürlüğü";
                ws.Cells[string.Format("B{0}", 12)].Value =hgmCount;
                ws.Cells[string.Format("A{0}", 13)].Value = "	ASAL Genel Müdürlüğü";
                ws.Cells[string.Format("B{0}", 13)].Value = asalCount;
                ws.Cells[string.Format("A{0}", 14)].Value = "	Kara Kuvvetleri Komutanlığı";
                ws.Cells[string.Format("B{0}", 14)].Value = kkkCount;
                ws.Cells[string.Format("A{0}", 15)].Value = "Hava Kuvvetleri Komutanlığı";
                ws.Cells[string.Format("B{0}", 15)].Value = hvkkCount;
                ws.Cells[string.Format("A{0}", 16)].Value = "Deniz Kuvvetleri Komutanlığı";
                ws.Cells[string.Format("B{0}", 16)].Value = dzkkCount;
                ws.Cells[string.Format("A{0}", 17)].Value = "Milli Savunma Üniversitesi";
                ws.Cells[string.Format("B{0}", 17)].Value = msuCount;
                ws.Cells[string.Format("A{0}", 18)].Value = "Askeri Sağlık Hizmerleri Genel Müdürlüğü";
                ws.Cells[string.Format("B{0}", 18)].Value = ashgmCount;
                ws.Cells[string.Format("A{0}", 19)].Value = "Genelkurmay Başkanlığı";
                ws.Cells[string.Format("B{0}", 19)].Value = gnkurCount;
                ws.Cells[string.Format("A{0}", 20)].Value = "Askeri Fabrika ve Tersane İşletme A.Ş.";
                ws.Cells[string.Format("B{0}", 20)].Value = asfatCount;
                ws.Cells["A6:B6"].Style.Font.Bold = true;
                ws.Cells["A:AZ"].AutoFitColumns();
                Response.Clear();
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", "attachment:filename" + "ExcelReport.xlsx");
                Response.BinaryWrite(pck.GetAsByteArray());
                Response.End();
            }
            catch (Exception)
            {
                ViewBag.Message = "Hata Oluştu Excel Dökümanı Oluşturulamadı!";
            }


        }
        public void ExcelImportInspectionWorkplaceService()
        {
            var workplace = _workplaceService.GetAll().Data.ToList();
            int count = workplace.Count();

            List<int> WorkplaceCountList = new List<int>();
            int sumPerson = 0;
            for (int i = 1; i <= count; i++)
            {
                var workplaceCount = _ıdentityService.WorkplaceCount(i).Data.Count();
                sumPerson = workplaceCount + sumPerson;
                WorkplaceCountList.Add(workplaceCount);
            }
            var sayi = WorkplaceCountList.ToList();
           


            try
            {
                ExcelPackage pck = new ExcelPackage();
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Report");

                ws.Cells["A6"].Value = "BİRİMİ";
                ws.Cells["B6"].Value = "GENEL MÜDÜRLÜK";
                ws.Cells["C6"].Value = "İŞ YERİ";
                int rowStart = 7;
                foreach (var item in workplace)
                {
                    ws.Cells[string.Format("A{0}", rowStart)].Value = item.Kuvvet;
                    ws.Cells[string.Format("B{0}", rowStart)].Value = item.Birimi;
                    ws.Cells[string.Format("C{0}", rowStart)].Value = item.IsYeriAdi;
                    rowStart++;
                }
                ws.Cells[string.Format("A{0}", rowStart)].Value ="TOPLAM";
                ws.Cells["D6"].Value = "KİŞİ SAYISI";
                rowStart = 7;
                foreach (var item in sayi)
                {
                    ws.Cells[string.Format("D{0}", rowStart)].Value = item;
                   
                    rowStart++;
                }
               
                ws.Cells[string.Format("D{0}", rowStart)].Value = sumPerson;
              
                ws.Cells["A6:D6"].Style.Font.Bold=true;
                
                ws.Cells["A:AZ"].AutoFitColumns();
                Response.Clear();
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", "attachment:filename" + "ExcelReport.xlsx");
                Response.BinaryWrite(pck.GetAsByteArray());
                Response.End();
            }
            catch (Exception)
            {
                ViewBag.Message = "Hata Oluştu Excel Dökümanı Oluşturulamadı!";
            }


        }

        private void WorkplaceCardCounts()
        {
            var afgmCount = _ıdentityService.AfgmForCount().Data.Count();
            var asalCount = _ıdentityService.AsalForCount().Data.Count();
            var asfatCount = _ıdentityService.AsfatForCount().Data.Count();
            var ashgmCount = _ıdentityService.AshgmForCount().Data.Count();
            var dzkkCount = _ıdentityService.DzkkForCount().Data.Count();
            var gnkurCount = _ıdentityService.GnkurForCount().Data.Count();
            var hgmCount = _ıdentityService.HgmForCount().Data.Count();
            var hvkkCount = _ıdentityService.HvkkForCount().Data.Count();
            var kkkCount = _ıdentityService.KkkForCount().Data.Count();
            var lgmCount = _ıdentityService.LgmForCount().Data.Count();
            var msuCount = _ıdentityService.MsuForCount().Data.Count();
            var tedgmCount = _ıdentityService.TedgmForCount().Data.Count();
            var tgmCount = _ıdentityService.TgmForCount().Data.Count();
            var yhgmCount = _ıdentityService.YhgmForCount().Data.Count();

            var sum = afgmCount + asalCount + asfatCount + ashgmCount + dzkkCount
                + gnkurCount + hgmCount + hvkkCount + kkkCount + lgmCount + msuCount + tedgmCount + tgmCount + yhgmCount;

            ViewBag.AfgmCount = afgmCount;//
            ViewBag.AsalCount = asalCount;//
            ViewBag.AsfatCount = asfatCount;//
            ViewBag.AshgmCount = ashgmCount;//
            ViewBag.DzkkCount = dzkkCount;//
            ViewBag.GnkurCount = gnkurCount;//
            ViewBag.HgmCount = hgmCount;
            ViewBag.HvkkCount = hvkkCount;
            ViewBag.KkkCount = kkkCount;
            ViewBag.LgmCount = lgmCount;
            ViewBag.MsuCount = msuCount;
            ViewBag.TedgmCount = tedgmCount;
            ViewBag.TgmCount = tgmCount;
            ViewBag.YhgmCount = yhgmCount;
            ViewBag.Sum = sum;
        }

    }
        
}

