using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CodeManager : ICodeService
    {
        ICodeDal _codeDal;

        public CodeManager(ICodeDal codeDal)
        {
            _codeDal = codeDal;
        }

        public IResult Add(Code code)
        {
            _codeDal.Add(code);
            return new SuccessResult("Kod eklendi");
        }

        public IResult Delete(Code code)
        {
            _codeDal.Delete(code);
            return new SuccessResult("Kod silindi");
        }

        public IDataResult<Code> Get(int id)
        {
            return new SuccessDataResult<Code>(_codeDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Code>> GetAll()
        {
            return new SuccessDataResult<List<Code>>(_codeDal.GetAll(), "Kodlar listelendi");
        }

        public IDataResult<List<Code>> IsGivenGift()
        {
            return new SuccessDataResult<List<Code>>(_codeDal.GetAll(c => c.Status == false),"Hediyesi verilmeyen kodlar listelendi");
        }

        public IResult Update(Code code)
        {
            _codeDal.Update(code);
            return new SuccessResult("Kod güncellendi.");
        }

    }
}
