using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICodeService
    {
        IDataResult<List<Code>> GetAll();
        IDataResult<Code> Get(int id);
        IDataResult<List<Code>> IsGivenGift();
        IResult Add(Code code);
        IResult Delete(Code code);
        IResult Update(Code code);
    }
}
