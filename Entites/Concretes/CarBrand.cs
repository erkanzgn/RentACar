using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concretes
{
    public class CarBrand:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
