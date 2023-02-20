using MediatR;
using System.Collections.Generic;
using WebPOS.Inventory.Core.Models;

namespace WebPOS.Inventory.Infrastructure.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<ProductDTO>>
    {
    }
}
