using MVC_Introduction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Introduction.Services
{
    public interface IUserService
    {
        IList<GetUsersViewModel> GetUsers();
    }
}
