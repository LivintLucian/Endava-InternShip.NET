using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Async
{
    class Provider
    {
        public static Provider CreateProvider(int _id, string _name , int _temperature)
        {
            return new Provider()
            {
                Id = _id,
                Name = _name,
                Temperature = _temperature,
            };
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Temperature { get; set; }

        public int GetTemperature()
        {
            Thread.Sleep(1000);
            return Temperature;
        }
    }
}
