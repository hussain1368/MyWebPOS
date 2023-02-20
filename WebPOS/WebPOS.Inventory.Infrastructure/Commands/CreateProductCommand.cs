using MediatR;
using WebPOS.Inventory.Core.Models;

namespace WebPOS.Inventory.Infrastructure.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public ProductDTO Product { get; set; }
    }
}
