using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicketingSystemTPOST.Models
{
    public class Employee
    {
        public int employeeID { get; set; }
        [Display(Name="Име на служителя")]
        public string employeeName { get; set; }

        public ICollection<Order> employees { get; set; }
    }
}