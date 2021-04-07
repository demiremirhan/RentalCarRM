using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Absrtact;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsTableContext>, ICarDal
    {
        public CarDetailDto GetCarDetails(int carId)
        {
            using (CarsTableContext context = new CarsTableContext())
            {
                var result =
                    from car in context.Cars.Where(c=>c.Id==carId)

                    join brand in context.Brands
                        on car.BrandId equals brand.BrandId
                    join color in context.Colors
                        on car.ColorId equals color.ColorId
                    join ci in context.CarImages
                        on car.Id equals ci.CarId
                    select new CarDetailDto
                    {
                        Id = car.Id,
                        BrandName = brand.BrandName,
                        ColorName = color.ColorName,
                        DailyPrice = car.DailyPrice,
                        ModelYear = car.ModelYear,
                        Description = car.Description,
                        ImagePath = ci.ImagePath,
                        BrandId = brand.BrandId,
                         ColorId = color.ColorId

                    };
                return result.FirstOrDefault();
            }
        }

        public List<CarDetailDto> GetCarsDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarsTableContext context = new CarsTableContext())
            {
                var result =
                    from car in context.Cars

                    join brand in context.Brands
                        on car.BrandId equals brand.BrandId
                    join color in context.Colors
                        on car.ColorId equals color.ColorId
                    join ci in context.CarImages
                        on car.Id equals ci.CarId
                    select new CarDetailDto
                    {
                        Id = car.Id,
                        BrandName = brand.BrandName,
                        ColorName = color.ColorName,
                        DailyPrice = car.DailyPrice,
                        ModelYear = car.ModelYear,
                        Description = car.Description,
                        ImagePath = ci.ImagePath,
                        BrandId = brand.BrandId,
                        ColorId = color.ColorId

                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
