using System;
using System.Collections.Generic;
using System.Text;
using XamAndCore.Model;
using XamAndCore.Ropsitory;

namespace XamAndCore.Service
{
    public class ProductService
    {
        private static ProductRepository repos  = new ProductRepository();

        public List<Products> GetAllProducts()
        {
            return repos.GetAllProducts();
        }

        public Products GetProductByID(int productid)
        {
            return repos.GetProductByID(productid);
        }

        public List<Group> GetProductGroups()
        {
            return repos.GetProductGroups();
        }

        public List<Products> GetProductsForGroup(int groupId)
        {
            return repos.GetProductsForGroup(groupId);
        }

        public List<Products> GetFavouriteProducts()
        {
            return repos.GetFavouriteProducts();
        }

    }
}
