using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class IdentityDal : EfEntityRepositoryBase<Identity, EmployeeContext>, IIdentityDal
    {
        public List<PersonDto> GetPersonDetails()
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from c in context.Identities
                             join v in context.Genders on c.CinsiyetId equals v.CinsiyetId
                             join b in context.MaritalStatuses on c.MedeniHalId equals b.MedeniHalId
                             join n in context.DisabilityStatuses on c.OzelDurumId equals n.OzelDurumId
                             select new PersonDto
                             {
                                 PersonelKimlikId = c.PersonelKimlikId,
                                 MedeniHali = b.MedeniHali,
                                 Cinsiyeti = v.Cinsiyeti,
                                 OzelDurum = n.OzelDurumu
                             };
               
                return result.ToList();
                         
            }
        }
    }
}
