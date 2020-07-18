using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;
using System.IdentityModel.Tokens.Jwt;

namespace POO_Concepts
{

    class Program
    {
        static void Main(string[] args)
        {
            var totalSalary = 0;

            using StreamReader r =
                new StreamReader(@"C:\Users\llivint\source\repos\POO Concepts\POO Concepts\Developers.json");
            string json = r.ReadToEnd();
            var objDeveloper = JsonConvert.DeserializeObject<List<Developer>>(json);

            foreach (var res in objDeveloper)
            {
                totalSalary += (int) res.CalculateSalary();
            }

            Console.WriteLine(totalSalary);
        }
    }
}
