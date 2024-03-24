using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concretes
{
    public  class CarColor:IEntity
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public int ColorId { get; set; }
    }
}
