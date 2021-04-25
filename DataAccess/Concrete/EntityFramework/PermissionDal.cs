using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class PermissionDal : EfEntityRepositoryBase<Permission, EmployeeContext>, IPermissionDal
    {
        public List<PermissionDto> GetPermissionDetails(Expression<Func<Permission, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from p in filter == null ? context.Permissions : context.Permissions.Where(filter)
                             join t in context.PermissionTypes on p.IzinTurId equals t.IzinTurId
                             join r in context.ReasonForPermissions on p.IzinNedenId equals r.IzinNedenId
                             select new PermissionDto
                             {
                                 PersonelKimlikId = p.PersonelKimlikId,
                                 PersonelIzinId = p.PersonelIzinId,
                                 IzinNedeni = r.IzinNedeni,
                                 IzinTuru = t.IzinTuru,
                                 BaslamaTarihi = p.BaslamaTarihi,
                                 BitisTarihi = p.BitisTarihi,
                                 IzinTurId=p.IzinTurId,
                                  IzinNedenId=p.IzinNedenId
                             };

                return result.ToList();

            }
        }
    }
}
