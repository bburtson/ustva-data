using System;

namespace USTVA.Data
{
    public partial class Incident
    {
        public int IncidentId { get; set; }
        public string Alcohol { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
        public int DriverId { get; set; }
        public string Fatal { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string SeatBelts { get; set; }
        public int VehicleId { get; set; }
        public int ViolationId { get; set; }

        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }
        public Violation Violation { get; set; }
    }
}

