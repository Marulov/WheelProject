using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGiftService
    {
        IDataResult<List<Gift>> GetAll();
        IDataResult<Gift> Get(int id);
        IDataResult<List<Gift>> IsGift();
        IResult Add(Gift gift);
        IResult Delete(Gift gift);
        IResult Update(Gift gift);
    }
}
