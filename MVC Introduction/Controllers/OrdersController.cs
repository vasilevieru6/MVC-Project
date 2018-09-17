using Models.Domain;
using MVC_Introduction.Models;
using MVC_Introduction.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Introduction.Controllers
{
    public class OrdersController : Controller
    {
        private IOrderService _orderService;
        private IUserService _userService;

        public OrdersController(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }
        // GET: Orders
        public ActionResult Index()
        {
            IList<GetOrdersViewModel> orders = _orderService.GetOrders();
            return View(orders);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ListUser()
        {
            IList<GetUsersViewModel> user = _userService.GetUsers();
            return View(user);
        }

        [HttpPost]
        public ActionResult Create(CreateOrderViewModel orderViewModel)
        {
            _orderService.CreateOrder(orderViewModel);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            var order = _orderService.EditOrder(id);
            return View(order);
        }
       
        [HttpPost]
        public ActionResult Edit(EditOrderViewModel editOrderViewModel)
        {
            _orderService.SaveOrder(editOrderViewModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(long id)
        {           
            _orderService.DeleteOrder(id);
            return RedirectToAction("Index");
        }


        //[HttpGet] 
        //public ActionResult Details()
    }
}