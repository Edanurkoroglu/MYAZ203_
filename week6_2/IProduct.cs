using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_2
{
    public interface IProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitInStock { get; set; }

        public void GetProduct();
        public decimal GetUnitPrice(int id);
    }
}