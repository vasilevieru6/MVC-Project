using MVC_Introduction.Services;
using Repo;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MVC_Introduction
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IOrderService, OrderService>();
            container.RegisterType<IRepository, Repository>();
            container.RegisterType<IUserService, UserService>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}