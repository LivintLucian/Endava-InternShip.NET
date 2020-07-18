using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Course_1__Namespaces_Types_Methods
{
    class GenericParameters<T1, T2>
        where T1 : class, new()
        where T2 : IGeneric<int, int>
    {
        public void ParametersTypes()
        {
            Type tOneParameter = typeof(T1);
            Type tTwoParameter = typeof(T2);

            Console.WriteLine("T1: " + tOneParameter + "\nT2: " + tTwoParameter);
        }
    }
}
