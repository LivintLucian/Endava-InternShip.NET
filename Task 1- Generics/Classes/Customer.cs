using System;
using System.Collections.Generic;
using System.Text;

namespace Course_1__Namespaces_Types_Methods
{
    class Customer
    {
        public static Customer CreateCustomer(int customerId, string customerName, DateTime customerBirthDate)
        {
            return new Customer()
            {
                Id = customerId,
                Name = customerName,
                BirthDate = customerBirthDate,
            };

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
