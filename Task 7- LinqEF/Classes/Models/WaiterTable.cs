using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class WaiterTable
    {
        public int WaiterId { get; set; }
        public Waiter Waiter { get; set; }
        public int TableID { get; set; }
        public OrderTable OrderTable { get; set; }
    }
}
