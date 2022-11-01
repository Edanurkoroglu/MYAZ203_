using Entities1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDB
{
    public static class ProductDB
    {
        public static List<Product> Products { get; set; }
        static ProductDB()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                    ProductId=1,
                    ProductName="Hp",
                    Price=15000,
                    Category = new Category(){CategoryId=1, CategoryName="Electronic"}
                },
                new Product()
                {
                    ProductId=2,
                    ProductName="MacBook",
                    Price=30000,
                    Category = new Category(){CategoryId=2, CategoryName="Electronic"}
                },
                new Product()
                {
                    ProductId=3,
                    ProductName="Iphone14",
                    Price=64000,
                    Category = new Category(){CategoryId=3, CategoryName="Electronic"}
                }
            };
        }
    }
}
