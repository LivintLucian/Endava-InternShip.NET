using System;
using System.Collections.Generic;
using System.Text;

namespace Course_1__Namespaces_Types_Methods
{
    class ReverseArray
    {
        public void ReverseArrayMethod<T>(T[] arr)
        {
            Array.Reverse(arr);
            foreach (var element in arr)
            {
                Console.WriteLine(element.ToString());
            }
        }
    }
}
