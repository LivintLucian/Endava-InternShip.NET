using System;

namespace PhoneFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p30 = new HuaweiP30();
            p30.Id = 123;
            p30.Name = "HuaweiP30";
            p30.PowerOn();
            p30.AccessInternet();
            p30.ConnectToDeviceViaNFC("TV");
            p30.MakeCall(0272727272);
            p30.PlayMP3("song.mp3");
            p30.ShareFileOverBluetooth("file.txt");
            Console.WriteLine(p30.GetInformation());
            p30.PowerOff();

            var nokia3310 = new Nokia3310();
            nokia3310.PlayMP3("song.mp3");

            var samsung= new Samsung();
            samsung.Name = "Samsung S10";
            samsung.PowerOn();
            samsung.AccessInternet();
        }
    }
}