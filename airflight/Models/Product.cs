using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace airflight.Models
{
    public class Product
    {
        
        public int Id { get; set; }
        public string ProductName { get; set; }
        
        public IFormFile Image { get; set; }
    }
}