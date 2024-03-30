using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concretes
{
    public class Customer:User , IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName {  get; set; }
    }
}
