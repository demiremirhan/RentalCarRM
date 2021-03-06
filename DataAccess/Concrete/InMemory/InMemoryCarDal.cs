using DataAccess.Absrtact;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{BrandId = 1, Id = 1, ColorId = 1, DailyPrice=1500, ModelYear =2010, Description="Suzuki Vitara -> SUV"},
                new Car{BrandId = 1, Id = 2, ColorId = 2, DailyPrice=1000, ModelYear =2000, Description="Hyundai Kona -> SUV - 2-door"},
                new Car{BrandId = 2, Id = 3, ColorId = 4, DailyPrice=1250, ModelYear =2002, Description="C-5 -> Hatcback"},
                new Car{BrandId = 3, Id = 2, ColorId = 1, DailyPrice=1750, ModelYear =2017, Description="VAN"},
                new Car{BrandId = 4, Id = 1, ColorId = 3, DailyPrice=1500, ModelYear =2020, Description="All Terrain Vehicle"},

            };
        }
        public void Add(Car cars)
        {
            _cars.Add(cars);
        }

        public void Delete(Car cars)
        {
            Car carsToDelete = _cars.SingleOrDefault(c => c.Id == cars.Id);
            _cars.Remove(cars);
        }

        public List<Car> GetAllByBrandId(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car cars)
        {
            Car carsToUpdate = _cars.SingleOrDefault(c => c.Id == cars.Id);
            carsToUpdate.Id = cars.Id;
            carsToUpdate.BrandId = cars.BrandId;
            carsToUpdate.ColorId = cars.ColorId;
            carsToUpdate.DailyPrice = cars.DailyPrice;
            carsToUpdate.ModelYear = cars.ModelYear;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailDto()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailDtoById(int carId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailDtoByBrand(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailDtoByColor(int colorId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarsDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public CarDetailDto GetCarDetails(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
