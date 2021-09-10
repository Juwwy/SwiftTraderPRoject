﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftTraderPRoject.Models.RestModels
{
    public class Products
    {
        public string ProductId { get; set; }
        public string CatId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public decimal Price { get; set; }
    }
}
