using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DependencyInjection
{
    public class SingleTon
    {
        private static readonly SingleTon _instance = new SingleTon();
        private List<int> numbers =new List<int>();
        private int nextNumber = 0;
        private SingleTon()
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }

        public static SingleTon GetNumbers()
        {
            return _instance;
        }
        public int GetNextNumber()
        {
            int output = numbers[nextNumber];

            nextNumber += 1;

            if (nextNumber >= numbers.Count)
            {
                nextNumber = 0;
            }


            return output;
        }
    }
}
