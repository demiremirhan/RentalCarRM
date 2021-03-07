using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IRentDal : IEntityRepository<Rental>
    {
        List<RentDetailDto> GetRentDetails(Expression<Func<Rental, bool>> filter = null);
    }
}
