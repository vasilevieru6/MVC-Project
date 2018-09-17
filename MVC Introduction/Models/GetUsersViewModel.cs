using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Introduction.Models
{
    public class GetUsersViewModel: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Name { get { return string.Format("{0} {1}", FirstName, LastName); } } 
    }
}