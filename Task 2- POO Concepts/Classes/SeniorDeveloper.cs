using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Concepts
{
    class SeniorDeveloper : Developer
    {
        public override double CalculateSalary()
        {
            return ((20 * (HourlyRate * WorkingHours)) / 100) +  HourlyRate * WorkingHours;
        }
    }
}
