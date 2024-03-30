using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DTOs
{
    public class RentalDetailDto
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string CarName { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime RentDate {  get; set; } 
        public DateTime? ReturnDate { get; set; }
    }
}
