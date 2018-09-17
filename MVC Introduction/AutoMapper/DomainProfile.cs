using AutoMapper;
using Models.Domain;
using MVC_Introduction.Models;

namespace MVC_Introduction.AutoMapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Product, GetProductsViewModel>();
            CreateMap<Product, EditProductViewModel>();
            CreateMap<EditProductViewModel, Product>();
            CreateMap<CreateProductViewModel, Product>()
                .ForMember(x => x.CartItems, y => y.Ignore())
                .ForMember(x => x.OrderLines, y => y.Ignore())
                .ForMember(x => x.Characteristics, y => y.Ignore());

            CreateMap<Order, GetOrdersViewModel>();
            CreateMap<CreateOrderViewModel, Order>();
            CreateMap<Order, EditOrderViewModel>();
            CreateMap<EditOrderViewModel, Order>();
        }
    }
}
