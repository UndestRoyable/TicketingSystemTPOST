using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketingSystemTPOST.Models
{
    public class Order
    {
        public int orderID { get; set; }
        public int employeeID { get; set; }
        public int ticketID { get; set; }
        public DateTime date { get; set; }
        public int countTicketsOfType { get; set; }
        public Employee employee { get; set; }
        public TicketType ticket { get; set; }


    }
}