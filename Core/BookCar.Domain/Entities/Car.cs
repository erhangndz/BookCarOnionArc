﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Domain.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public string Model { get; set; }
        public string ImageUrl { get; set; }
        public int Km { get; set; }
        public string GearType { get; set; }
        public byte Seat  { get; set; }
        public byte Luggage  { get; set; }
        public string Fuel  { get; set; }

        public List<CarFeature> CarFeatures { get; set; }
        public List<CarDetail> CarDetails { get; set; }
        public List<CarPricing> CarPricings { get; set; }

    }
}
