using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TicketingSystemTPOST.Models
{
    public class TicketingSystemTPOSTDBContext : DbContext
    {
        public DbSet<TicketType> TicketType { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}