using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CriminalDal : EfEntityRepositoryBase<Criminal, EmployeeContext>, ICriminalDal
    {
        public List<CriminalDto> GetCriminalDetails(Expression<Func<Criminal, bool>> filter = null)
        {
            using (EmployeeContext context =new EmployeeContext())
            {
                var result = from c in filter == null ? context.Criminals : context.Criminals.Where(filter)
                             join r in context.ReasonForCriminals on c.CezaNedenId equals r.CezaNedenId
                             select new CriminalDto
                             {
                                 PersonelKimlikId = c.PersonelKimlikId,
                                 PersonelCezaId = c.PersonelCezaId,
                                 CezaVerenAmir = c.CezaVerenAmir,
                                 CezaNedeni = r.CezaNedeni,
                                 CezayiVerenKisiAdi = c.CezayiVerenKisiAdi,
                                 CezaTarihi = c.CezaTarihi,
                                 VerilenCeza = c.VerilenCeza
                             };
                return result.ToList();
            }
        }
    }
}
