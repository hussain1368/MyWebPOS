using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebPOS.Inventory.Core.DataProviders;
using WebPOS.Inventory.Core.Models;
using WebPOS.Inventory.Infrastructure.Commands;
using WebPOS.Inventory.Infrastructure.Queries;

namespace WebPOS.Inventory.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMediator mediator;

        public ProductRepository(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var query = new GetProductsQuery { };
            return await mediator.Send(query);
        }
        public async Task<int> AddProduct(ProductDTO product)
        {
            var command = new CreateProductCommand
            {
                Product = product,
            };
            return await mediator.Send(command);
        }
    }
}
