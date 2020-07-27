namespace PhoneFactory
{
    public interface IPhone
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        void MakeCall(decimal number);
        void AccessInternet();
        void PlayMP3(string songName);
        void PowerOn();
        void PowerOff();
        string GetInformation();
    }
}