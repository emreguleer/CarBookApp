﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Domain.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km {  get; set; }
        public string Transmission {  get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string FuelType { get; set; }
        public string BigImageUrl { get; set; }
        public List<CarFeature> CarFeatures { get; set; }  
        public List<CarDescription> CarDescription { get; set; }
        public virtual List<CarPricing> CarPricings { get; set; }
    }
}
