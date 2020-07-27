using System;

namespace PhoneFactory
{
    public class HuaweiP30 : IPhone, IAddFunctionalities
    {
        public decimal Id { get; set; }
        public string Name { get; set; }

        public void MakeCall(decimal number)
        {
            Console.WriteLine($"Calling {number}");
        }

        public void AccessInternet()
        {
            Console.WriteLine("You are online!");
        }

        public void ShareFileOverBluetooth(string fileName)
        {
            Console.WriteLine($"Sharing file {fileName}");
        }

        public void PlayMP3(string songName)
        {
            Console.WriteLine($"Playing song {songName}");
        }

        public void ConnectToDeviceViaNFC(string deviceName)
        {
            Console.WriteLine($"Connected to {deviceName}");
            ;
        }

        public void PowerOn()
        {
            Console.WriteLine("Power is on!");
        }

        public void PowerOff()
        {
            Console.WriteLine("Device is shooting down!" + Environment.NewLine);
        }

        public string GetInformation()
        {
            return Environment.NewLine +
                   $"Id :{Id}" + Environment.NewLine +
                   $"Name :{Name}" + Environment.NewLine +
                   "Internet browsing: Yes" + Environment.NewLine +
                   "Bluetooth: 4.0" + Environment.NewLine +
                   "MP3: Yes" + Environment.NewLine +
                   "NFC: Yes" + Environment.NewLine;
        }
    }
}