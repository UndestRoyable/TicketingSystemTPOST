using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicketingSystemTPOST.Models
{
    public class Order
    {
        public int orderID { get; set; }
        public int employeeID { get; set; }
        [Display(Name="Вид билет (ID, трябва да се направи с dropdown и имена)")]
        public int ticketID { get; set; }
        [Display(Name="Дата")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime date { get; set; }
        [Display(Name="Брой билети")]
        public int countTicketsOfType { get; set; }
        public Employee employee { get; set; }
        public TicketType ticket { get; set; }


    }
}