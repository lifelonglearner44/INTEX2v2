﻿using System.ComponentModel.DataAnnotations;

namespace INTEX2v2.Models
{
    public class Product
    {
        [Key]
        public required int product_ID { get; set; }
        public required string name { get; set; }
        public required int year { get; set; }
        public required int num_parts { get; set; }
        public required int price { get; set; }
        public required string img_link { get; set; }
        public required string primary_color { get; set; }
        public string? secondary_color { get; set; }
        public required string description { get; set; }
        public required string category { get; set; }
    }
}
