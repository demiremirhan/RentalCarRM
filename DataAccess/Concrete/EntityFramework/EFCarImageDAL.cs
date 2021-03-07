using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete.EntityFramework;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EFCarImageDAL : EfEntityRepositoryBase<CarImage, CarTablesContext>, ICarImageDAL
    {

    }
}
