using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class Waiter
    {
        public int WaiterId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<WaiterTable> WaiterTables { get; set; }
    }
}
