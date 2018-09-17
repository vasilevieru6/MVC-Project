using Models.Domain;
using MVC_Introduction.Models;
using System.Collections.Generic;

namespace MVC_Introduction.Services
{
    public interface IProductService
    {
        IList<GetProductsViewModel> GetProducts();

        EditProductViewModel EditProduct(long id);
        Product CreateProduct(CreateProductViewModel productViewModel);
        Product FindProduct(long id);
        void DeleteProduct(GetProductsViewModel productsViewModel);
        void SaveProduct(EditProductViewModel editProductViewModel);
    }
}
