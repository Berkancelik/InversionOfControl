using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.console
{
    public class DAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{Id = 1, Name = "Kalem 1", Price = 100, Stock = 10},
                new Product{Id = 2, Name = "Kalem 2", Price = 200, Stock = 20},
                new Product{Id = 3, Name = "Kalem 3", Price = 300, Stock = 30},
                new Product{Id = 4, Name = "Kalem 4", Price = 400, Stock = 40}


            };
        }
    }
}
