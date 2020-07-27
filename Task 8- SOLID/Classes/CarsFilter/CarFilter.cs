using System;
using System.Collections.Generic;
using System.Linq;
using CarsFilter.Enums;

namespace CarsFilter
{
    public class CarFilter
    {
        public List<Car> FilterBy(IEnumerable<Car> cars, Func<Car, bool> condition) =>
            cars.Where(condition).ToList();
    }
}
