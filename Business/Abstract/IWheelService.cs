using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IWheelService
    {
        IDataResult<List<Wheel>> GetAll();
        IDataResult<Wheel> Get(int id);
        IResult Add(Wheel wheel);
        IResult Delete(Wheel wheel);
    }
}
