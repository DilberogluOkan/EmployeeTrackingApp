using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdaptationManager : IAdaptationService

    {
        IAdaptationDal _adaptationDal;

        public AdaptationManager(IAdaptationDal adaptationDal)
        {
            _adaptationDal = adaptationDal;
        }

        public IResult Add(Adaptation adaptation)
        {
            if (adaptation.HizmetinGecKurum==null)
            {
                return new ErrorDataResult<Adaptation>(Messages.Error);
            }
            _adaptationDal.Add(adaptation);
            return new SuccessResult(Messages.AddPositive);
        }

        public IResult Delete(Adaptation adaptation)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Adaptation>> GetAll()
        {
            return new SuccessDataResult<List<Adaptation>>(_adaptationDal.GetAll(), Messages.Success);
        }

        public IDataResult<List<Adaptation>> GetAllByIdentityId(int id)
        {
            return new SuccessDataResult<List<Adaptation>>(_adaptationDal.GetAll(p => p.IntibakBilgiId == id));
        }

        public IDataResult<Adaptation> GetById(int adaptationId)
        {
            return new SuccessDataResult<Adaptation>(_adaptationDal.Get(p => p.IntibakBilgiId == adaptationId));
        }

        public IResult Update(Adaptation adaptation)
        {
            if (adaptation.HizmetinGecKurum==null)
            {
                return new ErrorResult(Messages.UpdateNegative);
            }
            _adaptationDal.Update(adaptation);
            return new SuccessResult(Messages.UpdatePositive);
        }
    }
}
