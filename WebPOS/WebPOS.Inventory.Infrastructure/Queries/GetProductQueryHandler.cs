using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebPOS.Inventory.Core.Models;
using WebPOS.Inventory.Infrastructure.Domain;

namespace WebPOS.Inventory.Infrastructure.Queries
{
    public class GetProductQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<ProductDTO>>
    {
        private readonly WebPOS_InventoryContext context;
        private readonly IMapper mapper;

        public GetProductQueryHandler(WebPOS_InventoryContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await context.Products.Where(p => true).ToListAsync();
            return mapper.Map<List<ProductDTO>>(products);
        }
    }
}
