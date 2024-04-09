using Business.Abstract;
using Business.Constants;
using Core.Entities.Concretes;
using Core.Utilities.Business;
using Core.Utilities.Helper.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CarImageManager:ICarImageService
    {
       
            private readonly ICarImageDal _carImageDal;
            private readonly IFileHelper _fileHelper;

            public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
            {
                _fileHelper = fileHelper;
                _carImageDal = carImageDal;
            }
            
            public IResult Add(IFormFile file, CarImage carImage)
            {
                IResult? result = BusinessRules.Run(CountByCarId(carImage));
                if (result != null)
                {
                    return result;
                }

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

          
            public IResult Update(IFormFile file, CarImage carImage)
            {
                _fileHelper.Update(file, carImage.ImagePath!);
                carImage.Date = DateTime.Now;
                _carImageDal.Update(carImage);
                return new SuccessDataResult<CarImage>(carImage);
            }
            public IDataResult<List<CarImage>> GetAll()
            {
                return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
            }

            public IDataResult<CarImage> GetById(int id)
            {
                return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.ImageId == id));
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

            private IResult CountByCarId(CarImage carImage)
            {
                if (_carImageDal.GetAll(c => c.CarId == carImage.CarId).Count >= 5)
                {
                    return new ErrorResult(Messages.ImageLimitExceded);
                }
                else
                {
                    return new SuccessResult();
                }
            }


        
    }
}
