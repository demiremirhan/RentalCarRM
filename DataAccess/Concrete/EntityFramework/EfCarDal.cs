﻿using Core.DataAccess.EntityFramework;
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
        public List<CarDetailDto> GetCarDetailDto()
        {
            using (CarsTableContext context = new CarsTableContext())
            {
                var result = from car in context.CarsOld
                             join brand in context.Brands
                             on car.Id equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description
                             };
                return result.ToList();
            }
        }
    }
}
