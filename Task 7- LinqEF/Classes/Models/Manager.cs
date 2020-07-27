using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int RestaurantId { get; set; }
        public RestaurantBranch RestaurantOwner { get; set; }
    }
}
