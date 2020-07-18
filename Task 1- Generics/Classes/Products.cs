using System;
using System.Collections.Generic;
using System.Text;

namespace Course_1__Namespaces_Types_Methods
{
    public class Products
    {
        public static Products CreateProducts(string name)
        {
            return new Products()
            {
                Name = name,
            };
        }
        public string Name { get; set; }
    }
}
