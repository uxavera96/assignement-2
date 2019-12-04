﻿
using System;

namespace ProductWeb.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
      
    }
}