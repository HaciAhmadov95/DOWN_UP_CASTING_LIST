using Domain.Models;
using Service.Data;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    internal class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return AppDbContext.Products();
        }
    }
}
