using System;
using System.Collections.Generic;
using System.Text;

namespace Course_1__Namespaces_Types_Methods
{
    interface IRepository<T>
    {
        public void Create(T product);
        public List<T> GetAll();
        public void Update(T newProduct);
        public void Delete(T product);
    }
}
