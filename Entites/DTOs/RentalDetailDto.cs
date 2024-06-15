using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DTOs
{
    public class RentalDetailDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string BrandName { get; set;}
        public decimal DailyPrice { get; set; }
        public DateTime RentDate {  get; set; } 
        public DateTime? ReturnDate { get; set; }
    }
}
