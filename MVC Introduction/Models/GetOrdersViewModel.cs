using Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Introduction.Models
{

    public class GetOrdersViewModel : BaseEntity
    {
        [Required]
        public string Number { get; set; }
        public string Description { get; set; }
        [Required]
        public int TotalAmount { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string Status { get; set; }
        
    }
}