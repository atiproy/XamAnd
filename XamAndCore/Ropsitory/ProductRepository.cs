using System;
using System.Collections.Generic;
using System.Text;
using XamAndCore.Model;
using System.Linq;

namespace XamAndCore.Ropsitory
{
    public class ProductRepository
    {
        private static List<Group> ProductsGroup = new List<Group>()
        {
            new Group()
            {
                GroupId =1, Title="1st Group", ImagePath="", ProductList = new List<Products>
                {
                    new Products()
                    {
                        ProductId = 1,
                        ProductName = "ABC",
                        ShortDescription="Good",
                        Description="To Be Disclosed later",
                        ImagePath="Product1",
                        Available=true,
                        PrepTime=30,
                        Ingredients= new List<string>(){"a","b","c","d"},
                        Price=145,
                        IsFavourite=true
                    },
                    new Products()
                    {
                        ProductId = 2,
                        ProductName = "DEF",
                        ShortDescription="Good",
                        Description="To Be Disclosed later",
                        ImagePath="Product1",
                        Available=true,
                        PrepTime=30,
                        Ingredients= new List<string>(){"a","b","c","d"},
                        Price=145,
                        IsFavourite=true
                    },
                    new Products()
                    {
                        ProductId = 3,
                        ProductName = "GHI",
                        ShortDescription="Good",
                        Description="To Be Disclosed later",
                        ImagePath="Product1",
                        Available=true,
                        PrepTime=30,
                        Ingredients= new List<string>(){"a","b","c","d"},
                        Price=145,
                        IsFavourite=false
                    },
                    new Products()
                    {
                        ProductId = 4,
                        ProductName = "JKL",
                        ShortDescription="Good",
                        Description="To Be Disclosed later",
                        ImagePath="Product1",
                        Available=true,
                        PrepTime=30,
                        Ingredients= new List<string>(){"a","b","c","d"},
                        Price=145,
                        IsFavourite=false
                    },
                }
            },

             new Group()
            {
                GroupId =2, Title="2nd Group", ImagePath="", ProductList = new List<Products>
                {
                    new Products()
                    {
                        ProductId = 5,
                        ProductName = "X",
                        ShortDescription="Good",
                        Description="To Be Disclosed later",
                        ImagePath="Product1",
                        Available=true,
                        PrepTime=30,
                        Ingredients= new List<string>(){"a","b","c","d"},
                        Price=145,
                        IsFavourite=false
                    },
                    new Products()
                    {
                        ProductId = 6,
                        ProductName = "Y",
                        ShortDescription="Good",
                        Description="To Be Disclosed later",
                        ImagePath="Product1",
                        Available=true,
                        PrepTime=30,
                        Ingredients= new List<string>(){"a","b","c","d"},
                        Price=145,
                        IsFavourite=false
                    },
                    new Products()
                    {
                        ProductId = 7,
                        ProductName = "Z",
                        ShortDescription="Good",
                        Description="To Be Disclosed later",
                        ImagePath="Product1",
                        Available=true,
                        PrepTime=30,
                        Ingredients= new List<string>(){"a","b","c","d"},
                        Price=145,
                        IsFavourite=true
                    },
                }
            }
        };

        public List<Products> GetAllProducts()
        {
            IEnumerable<Products> products =
                from Group in ProductsGroup
                from Products in Group.ProductList

                select Products;

            return products.ToList<Products>();
        }

        public Products GetProductByID(int productid)
        {
            IEnumerable<Products> product =
                from Group in ProductsGroup
                from Products in Group.ProductList
                where Products.ProductId == productid
                select Products;

            return product.FirstOrDefault();
        }

        public List<Group> GetProductGroups()
        {
            return ProductsGroup;
        }

        public List<Products> GetProductsForGroup(int groupId)
        {
            var group = ProductsGroup.Where(h => h.GroupId == groupId).FirstOrDefault();
            if (group != null)
            {
                return group.ProductList;
            }
            return null;
        }

        public List<Products> GetFavouriteProducts()
        {
            IEnumerable<Products> products =
                from Group in ProductsGroup
                from Products in Group.ProductList
                where Products.IsFavourite
                select Products;

            return products.ToList<Products>();
        }
    }
}
