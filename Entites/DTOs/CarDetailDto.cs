﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice {  get; set; }
        public string ColorName { get; set; }
        public int ColorId { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }   
        public string?ImagePath {  get; set; }  

    }
}
