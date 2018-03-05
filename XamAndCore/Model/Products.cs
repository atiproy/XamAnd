using System;
using System.Collections.Generic;
using System.Text;

namespace XamAndCore.Model
{
    public  class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public float Price { get; set; }
        public bool Available { get; set; }
        public int PrepTime { get; set; }
        public List<string> Ingredients { get; set; }
        public bool IsFavourite { get; set; }
        public string GroupName { get; set; }
    }
}
