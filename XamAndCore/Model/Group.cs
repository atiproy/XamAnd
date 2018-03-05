using System;
using System.Collections.Generic;
using System.Text;

namespace XamAndCore.Model
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public List<Products> ProductList { get; set; }
    }
}
