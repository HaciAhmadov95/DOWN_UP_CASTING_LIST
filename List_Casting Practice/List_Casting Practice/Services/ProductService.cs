using List_Casting_Practice.Data;
using List_Casting_Practice.Models;
using List_Casting_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Casting_Practice.Services
{
    internal class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return AppDbContext.Products();
        }

        public List<Product> GetAllByDescending()
        {
          return AppDbContext.Products().OrderByDescending(x => x.Id).ToList();
        }

        public Product GetById(int id)
        {
            return AppDbContext.Products().FirstOrDefault(m => m.Id == id);
        }
    }
}
