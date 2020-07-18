using System;
using System.Collections.Generic;
using System.Text;

namespace Course_1__Namespaces_Types_Methods
{
    class HashSet
    {
        public HashSet(HashSet<int> hash)
        {
            for (int i = 0; i < 5; ++i)
            {
                hash.Add((i * 2) + 1);
            }
        }
        public void DisplayHash(HashSet<int> hash)
        {
            foreach (var element in hash)
            {
                Console.WriteLine(element);
            }
        }
    }
}
