using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Helper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concretes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal,IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
   
            string guid = _fileHelper.Add(file);
            carImage.ImagePath = guid;
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessDataResult<CarImage>(carImage);

        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            _fileHelper.Delete(carImage.ImagePath!);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            _carImageDal.GetAll();
            return new SuccessDataResult<List<CarImage>>();
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            var carImages = _carImageDal.GetAll(c => c.CarId == carId);
            if (carImages.Count == 0)
            {
                carImages.Add(new CarImage() { CarId = carId, ImagePath = "default.png" });
                return new SuccessDataResult<List<CarImage>>(carImages);
            }
            return new SuccessDataResult<List<CarImage>>(carImages);
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            _fileHelper.Update(file, carImage.ImagePath!);
            carImage.Date = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessDataResult<CarImage>(carImage);
        }
        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.ImageId == id));
        }
    }

}
