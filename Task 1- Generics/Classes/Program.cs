using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Course_1__Namespaces_Types_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercise one.
             */
            ReverseArray arrObj=new ReverseArray();
            int[] arr = new int[] {1, 2, 3, 4};
            string[] arrString = new string[] {"ana", "are", "mere"};
            //arrObj.ReverseArrayMethod<string>(arrString);

            /*
             * Exercise two.
             */
            GenericParameters<ReverseArray, IGeneric<int, int>> gpObj = new GenericParameters<ReverseArray, IGeneric<int, int>>();
            //gpObj.ParametersTypes();
            //Type type = gpObj.GetType().GetTypeInfo().GetGenericArguments()[0];
            //Console.WriteLine(type);

            /*
             * Exercise three.
             */
            HashSet<int> hashSet= new HashSet<int>();
            HashSet hash=new HashSet(hashSet);
            //hash.DisplayHash(hashSet);

            /*
             * 4th.
             */
            var orders = new List<Order>()
            {
                Order.CreateOrder(1, "Black TShirt", DateTime.Today),
                Order.CreateOrder(2, "Purple TShirt", DateTime.Today),
                Order.CreateOrder(3, "Yellow TShirt", DateTime.Today),
            };

            var customers = new Dictionary<Customer, Order>()
            {
                {Customer.CreateCustomer(1, "Pavel", DateTime.Today), orders[0]},
                {Customer.CreateCustomer(2, "Ion", DateTime.Today), orders[1]},
                {Customer.CreateCustomer(3, "Luca", DateTime.Today), orders[2]},
            };

            foreach (var entry in customers)
            {
                Console.WriteLine(entry.Key.Name + " are comanda cu id-ul: " + entry.Value.Id + " si a comandat un: " + entry.Value.Name);
            }
        }
    }
}
