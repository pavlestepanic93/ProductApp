using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}
