using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Program objProgram = new Program();
            objProgram.ReportTime();
            Console.Write("ASync Time: ");
            objProgram.ReportTimeAsync();
        }

        public List<Provider> InitProviders()
        {
            var providers = new List<Provider>();

            providers.Add(Provider.CreateProvider(1, "Busu2", 35));
            providers.Add(Provider.CreateProvider(1, "Ioan", 29));
            providers.Add(Provider.CreateProvider(1, "Sebastian", 31));
            providers.Add(Provider.CreateProvider(1, "Stefan", 28));
            providers.Add(Provider.CreateProvider(1, "Alexandru", 27));

            return providers;
        }

        public void GetTemperature()
        {
            List<Provider> providersTemp = InitProviders();
            foreach (var entry in providersTemp)
            {
                var result = entry.GetTemperature();
            }
        }

        public async Task<long> GetTemperatureAsync()
        {
            List<Provider> providersTemp = InitProviders();

            List<Task<int>> providersASync = new List<Task<int>>();

            foreach (var entry in providersTemp)
            {
                //var result = await Task.Run(() => entry.Temperature);
                providersASync.Add(Task.Run(() => entry.GetTemperature()));
            }

            var results = await Task.WhenAll(providersASync);
            return 1;
        }
        public long Timer()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            GetTemperature();
            watch.Stop();
            var timeMS = watch.ElapsedMilliseconds;

            return timeMS;
        }

        public async Task<long> TimerAsync()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = await GetTemperatureAsync();
            watch.Stop();
            var timeMS = watch.ElapsedMilliseconds;

            Console.WriteLine(timeMS);
            return 1;
        }

        public void ReportTime()
        {
            Console.WriteLine("Sync time: " + Timer());
        }

        public void ReportTimeAsync()
        {
            TimerAsync().Wait();
        }
    }
}

//Aplicatie de meteo- Lista de prognoze meteo, care-ti trimit temperatura pe maine. Temperatura( media temp primite de la providerii)
//Varianta in care iei toate prognozele si le faci media si returnezi
//Varianta rapida, asteapta primele 3 rezultate, face media si returneaza ( restul 7 sunt ignorante ).
//In cazul in care gasiti o solutie, tratati exceptiile.
// *Calculele in paralel