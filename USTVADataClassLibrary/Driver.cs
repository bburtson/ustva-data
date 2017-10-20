namespace USTVA.Data
{
    public partial class Driver
    {
        public int DriverId { get; set; }
        public string City { get; set; }
        public string CommercialLicense { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string State { get; set; }

        public Incident Incident { get; set; }
    }
}

