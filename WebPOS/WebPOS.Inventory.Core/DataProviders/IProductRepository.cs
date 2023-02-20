using System.Collections.Generic;
using System.Threading.Tasks;
using WebPOS.Inventory.Core.Models;

namespace WebPOS.Inventory.Core.DataProviders
{
    public interface IProductRepository
    {
        public Task<IEnumerable<ProductDTO>> GetProducts();
        public Task<int> AddProduct(ProductDTO product);
    }
}
