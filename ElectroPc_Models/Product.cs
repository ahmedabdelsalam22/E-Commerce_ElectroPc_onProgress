﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroPc_Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Processor { get; set; }
        public int RamSizeGB { get; set; }
        public string StorageType { get; set; }
        public int StorageCapacityGB { get; set; }
        public double DisplaySizeInches { get; set; }
        public string DisplayResolution { get; set; }
        public string GraphicsCard { get; set; }
        public string OperatingSystem { get; set; }
        public double BatteryLifeHours { get; set; }
        public double WeightKg { get; set; }
        public string Dimensions { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        public double Price { get; set; }

    }
}
