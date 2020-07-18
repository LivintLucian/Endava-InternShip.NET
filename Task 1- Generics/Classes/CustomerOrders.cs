using System;
using System.Collections.Generic;
using System.Text;

namespace Course_1__Namespaces_Types_Methods
{
    class CustomerOrders<T> : IRepository<T>
    {
        public List<T> products=new List<T>();
        public void Create(T product)
        {
            products.Add(product);
        }

        public List<T> GetAll()
        {
            return products;
        }

        public void Update(T newProduct)
        {
            throw new NotImplementedException();
        }

        public void Delete(T product)
        {
            products.Remove(product);
        }
    }
}
