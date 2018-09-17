using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Models.Domain;
using MVC_Introduction.Models;
using Repo;

namespace MVC_Introduction.Services
{
    public class OrderService : IOrderService
    {

        private IRepository _repository;
        public OrderService(IRepository repository)
        {
            _repository = repository;
        }

        //public List<SelectListItem> GetAllUsers()
        //{
        //    //var users = _repository.GetAll<User>();
        //    var users = PopulateUsers();
        //    //Mapper.Map<IList<User>, IList<CreateOrderViewModel>>(users.ToList());

        //    return users;
        //}

        //private List<SelectListItem> PopulateUsers()
        //{
        //    List<SelectListItem> items = new List<SelectListItem>();
        //    var users = Mapper.Map<IList<User>, IList<GetUsersViewModel>>(_repository.GetAll<User>().ToList());
        //    foreach (var item in users)
        //    {
        //        items.Add(new SelectListItem
        //        {
        //            Text = item.Name,
        //            Value = item.Name
        //        });
        //    }
        //    return items;
        //}

        public IList<GetOrdersViewModel> GetOrders()
        {
            var orders = _repository.GetAll<Order>().ToList();

            return Mapper.Map<IList<Order>, IList<GetOrdersViewModel>>(orders);
        }

        public Order CreateOrder(CreateOrderViewModel createOrderViewModel)
        {
            var order = Mapper.Map<CreateOrderViewModel, Order>(createOrderViewModel);

            var users = _repository.GetAll<User>();

            var user = users.Take(1).ToList();
            if (user.Count == 1)
            {
                order.UserId = user[0].Id;
            }
            else
            {
                throw new ArgumentNullException();
            }

            _repository.Add(order);
            return order;
        }

        public EditOrderViewModel EditOrder(long id)
        {
            var order = _repository.GetById<Order>(id);
            return Mapper.Map<Order, EditOrderViewModel>(order);
        }

        public void SaveOrder(EditOrderViewModel editOrderViewModel)
        {
            var order = Mapper.Map<EditOrderViewModel, Order>(editOrderViewModel);

            _repository.Update(order);
        }

        public void DeleteOrder(long id)
        {
            var order = _repository.GetById<Order>(id);
            _repository.Delete(order);
        }   
    }
}