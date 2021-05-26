using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class WheelManager : IWheelService
    {
        IWheelDal _wheelDal;

        public WheelManager(IWheelDal wheelDal)
        {
            _wheelDal = wheelDal;
        }

        public IResult Add(Wheel wheel)
        {
            _wheelDal.Add(wheel);
            return new SuccessResult("Çark Eklendi");
        }

        public IResult Delete(Wheel wheel)
        {
            _wheelDal.Delete(wheel);
            return new SuccessResult("Çark Silindi");
        }

        public IDataResult<Wheel> Get(int id)
        {
            return new SuccessDataResult<Wheel>(_wheelDal.Get(w => w.Id == id));
        }

        public IDataResult<List<Wheel>> GetAll()
        {
            return new SuccessDataResult<List<Wheel>>(_wheelDal.GetAll(), "Çarklar listelendi");
        }
    }
}
