using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Course_1__Namespaces_Types_Methods
{
    public class Order
    {
        public static Order CreateOrder(int orderId, string orderName, DateTime orderDate)
        {
            return new Order()
            {
                Id = orderId,
                Name = orderName,
                OrderDate = orderDate,
                Product = new List<Products>()
            };
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime OrderDate { get; set; }

        public List<Products> Product { get; set; }
    }
}
