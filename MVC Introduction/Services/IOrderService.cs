using Models.Domain;
using MVC_Introduction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVC_Introduction.Services
{
    public interface IOrderService
    {
        IList<GetOrdersViewModel> GetOrders();
        //List<SelectListItem> GetAllUsers();
        Order CreateOrder(CreateOrderViewModel createOrderViewModel);
        EditOrderViewModel EditOrder(long id);
        void SaveOrder(EditOrderViewModel editOrderViewModel);
        void DeleteOrder(long id);
    }
}
