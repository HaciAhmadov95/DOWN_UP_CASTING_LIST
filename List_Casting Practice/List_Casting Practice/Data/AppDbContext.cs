using List_Casting_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Casting_Practice.Data
{
    internal static class AppDbContext
    {
        public static List<Product> Products()
        {
            new List<Product>()
            {
                new Product { Id = 1,Name = "Nokia1", Price =4000},
                 new Product { Id = 2,Name = "Nokia2", Price =400},
                  new Product { Id = 3,Name = "Nokia3", Price =4800}
            };

            return new List<Product>();
        }
    }
}
