using Core.DataAccess.EntityFramework;
using DataAccess.Absrtact;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarsTableContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDto()
        {
            using (CarsTableContext context = new CarsTableContext())
            {
                var result =
                            from r in context.Rentals
                            join car in context.Cars on r.CarId equals car.Id
                            join b in context.Brands on car.BrandId equals b.BrandId
                            join cust in context.Customers on r.CustomerId equals cust.CustomerId
                            join us in context.Users on cust.UserId equals us.Id
                            select new RentalDetailDto()
                            {
                                RentalDtoId = r.Id,
                                BrandName = b.BrandName,
                                RentDate = r.RentDate,
                                ReturnDate = r.ReturnDate,
                                FirstName = us.FirstName,
                                LastName = us.LastName

                            };

                return result.ToList();
            }

        }
    }
}
