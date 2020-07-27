using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneFactory
{
    class Samsung : IPhone
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public void MakeCall(decimal number)
        {
            Console.WriteLine($"Call {number}");
        }

        public void AccessInternet()
        {
            Console.WriteLine("Connect to the internet");
        }

        public void PlayMP3(string songName)
        {
            Console.WriteLine($"Play {songName}");
        }

        public void PowerOn()
        {
            Console.WriteLine("Power On");
        }

        public void PowerOff()
        {
            Console.WriteLine("Power Off");
        }

        public string GetInformation()
        {
            return Environment.NewLine +
                   $"Id :{Id}" + Environment.NewLine +
                   $"Name :{Name}" + Environment.NewLine +
                   "Internet browsing: No" + Environment.NewLine +
                   "MP3: No" + Environment.NewLine +
                   "NFC: No" + Environment.NewLine;
        }
    }
}
