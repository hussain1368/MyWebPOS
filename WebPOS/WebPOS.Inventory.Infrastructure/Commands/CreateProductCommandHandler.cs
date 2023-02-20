using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WebPOS.Inventory.Infrastructure.Domain;

namespace WebPOS.Inventory.Infrastructure.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly WebPOS_InventoryContext context;
        private readonly IMapper mapper;

        public CreateProductCommandHandler(WebPOS_InventoryContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = mapper.Map<Product>(request.Product);
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
            return product.Id;
        }
    }
}
