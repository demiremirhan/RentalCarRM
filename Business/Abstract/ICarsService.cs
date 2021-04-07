using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Absrtact
{
    public interface ICarsService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByBrandId(int id);
        IDataResult<List<Car>> GetAllByColorId(int id);
        IDataResult<Car> GetModelYear(int year);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<CarDetailDto> GetCarDetails(int carId);
        IDataResult<List<CarDetailDto>> GetCarsWithDetails();

        IDataResult<List<CarDetailDto>> GetCarsByBrandAndColor(int brandId, int colorId);
        IResult AddTransactional(Car car);
    }
}
