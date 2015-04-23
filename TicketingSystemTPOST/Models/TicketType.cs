using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicketingSystemTPOST.Models
{
    public class TicketType
    {
        public int ticketTypeID { get; set; }
        [Display(Name="Вид на билета")]
        public string ticketName { get; set; }
        [Display(Name = "Цена на билета")]
        public decimal ticketPrice { get; set; }

        public ICollection<Order> tickets { get; set; }
    }
}