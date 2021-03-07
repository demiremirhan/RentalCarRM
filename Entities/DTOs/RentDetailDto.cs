using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class RentDetailDto : IDto
    {
        public string CustomerName { get; set; }
        public int CarId { get; set; }
        public string UserName { get; set; }
        public string BrandName { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public int Id { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
