using System.Collections.Generic;
using System.Linq;
using Models.Domain;
using Repo;
using AutoMapper;
using MVC_Introduction.Models;

namespace MVC_Introduction.Services
{
    public class ProductService : IProductService
    {
        private IRepository _repository;
        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public EditProductViewModel EditProduct(long id)
        {
            var product = _repository.GetById<Product>(id);

            return Mapper.Map<Product, EditProductViewModel>(product);
        }


        public IList<GetProductsViewModel> GetProducts()
        {
            var products = _repository.GetAll<Product>().ToList();

            return Mapper.Map<IList<Product>, IList<GetProductsViewModel>>(products);
        }

        public Product CreateProduct(CreateProductViewModel prod)
        {
            var product = Mapper.Map<CreateProductViewModel, Product>(prod);
            _repository.Add(product);
            
            return product;
        }

        public Product FindProduct(long id)
        {
            var product = _repository.GetById<Product>(id);

            return product;
        }

        public void DeleteProduct(GetProductsViewModel productsViewModel)
        {
           var product =  _repository.GetById<Product>(productsViewModel.Id);
            _repository.Delete(product);            
        }

        public void SaveProduct(EditProductViewModel editProductViewModel)
        {
            var product = Mapper.Map<EditProductViewModel, Product>(editProductViewModel);

            _repository.Update(product);
        }
    }
}
