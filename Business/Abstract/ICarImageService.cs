using Core.Utilities.Results;
using Entites.Concretes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        public IResult Add(IFormFile formFile,CarImage carImamge);
        public IResult Delete(CarImage carImage);
        public IResult Update(IFormFile formFile ,CarImage carImamge);
        public IDataResult<List<CarImage>> GetAll();
        public IDataResult<CarImage>GetById(int imageId);
        public IDataResult<List<CarImage>> GetByCarId(int carId);

    }
}
