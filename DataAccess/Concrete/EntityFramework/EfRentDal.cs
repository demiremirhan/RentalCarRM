using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentDal : EfEntityRepositoryBase<Rental, CarTablesContext>, IRentDal
    {
        public List<RentDetailDto> GetRentDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarTablesContext context = new CarTablesContext())
            {
                var result = from r in context.Rentals
                             join c in context.CarsOld
                                 on r.CarId equals c.Id
                             join b in context.Brands
                                 on c.BrandId equals b.BrandId
                             join cu in context.Customers
                                 on r.CustomerId equals cu.CustomerId
                             //join u in context.Users  
                             //    on cu.CustomerId equals u.UserId
                             select new RentDetailDto
                             {
                                 Id = r.CustomerId,
                                 CarId = r.CarId,
                                 BrandName = b.BrandName,
                                 //UserFirstName = u.UserFirstName,
                                 //UserLastName = u.UserLastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }

        }


    }
}
