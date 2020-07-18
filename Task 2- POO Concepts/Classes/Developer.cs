using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace POO_Concepts
{
    [JsonObject]
    public class Developer : ICalculateSalary, IEnumerable
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Level")]
        public string Level { get; set; }
        [JsonProperty("HourlyRate")]
        public double HourlyRate { get; set; }
        [JsonProperty("WorkingHours")]
        public int WorkingHours { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name + " Level: " + Level + " WorkingHours: " + WorkingHours + " HourlyRate: " + HourlyRate;
        }

        public virtual double CalculateSalary()
        {
            if (Level == "Senior Developer")
            {
                return ((20 * (HourlyRate * WorkingHours)) / 100) + HourlyRate * WorkingHours;
            }
            else
            {
                return WorkingHours * HourlyRate;
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
