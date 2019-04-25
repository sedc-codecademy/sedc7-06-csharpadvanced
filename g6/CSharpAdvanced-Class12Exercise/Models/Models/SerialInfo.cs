namespace Models.Models
{
    public class SerialInfo
    {
        public string SerialNumber { get; set; }
        public int BuildVersion { get; set; }

        public SerialInfo()
        {

        }

        public SerialInfo(string serialNumber, int buildVersion)
        {
            SerialNumber = serialNumber;
            BuildVersion = buildVersion;
        }
    }
}
