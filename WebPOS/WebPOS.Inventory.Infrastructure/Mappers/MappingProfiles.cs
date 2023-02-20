using AutoMapper;
using WebPOS.Inventory.Core.Models;
using WebPOS.Inventory.Infrastructure.Domain;

namespace WebPOS.Inventory.Infrastructure.Mappers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
