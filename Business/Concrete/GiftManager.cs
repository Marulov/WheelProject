using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GiftManager : IGiftService
    {
        IGiftDal _giftDal;

        public GiftManager(IGiftDal giftDal)
        {
            _giftDal = giftDal;
        }

        public IResult Add(Gift gift)
        {
            _giftDal.Add(gift);
            return new SuccessResult("Hediye eklendi");
        }

        public IResult Delete(Gift gift)
        {
            _giftDal.Delete(gift);
            return new SuccessResult("Hediye silindi");
        }

        public IDataResult<Gift> Get(int id)
        {
            return new SuccessDataResult<Gift>(_giftDal.Get(g => g.Id == id));
        }

        public IDataResult<List<Gift>> GetAll()
        {
            return new SuccessDataResult<List<Gift>>(_giftDal.GetAll(), "Hediyeler listelendi");
        }

        public IDataResult<List<Gift>> IsGift()
        {
            return new SuccessDataResult<List<Gift>>(_giftDal.GetAll(g => g.Status == true));
            
        }

        public IResult Update(Gift gift)
        {
            _giftDal.Update(gift);
            return new SuccessResult("Hediye güncellendi");
        }
    }
}
