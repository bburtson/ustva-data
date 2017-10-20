namespace USTVA.Data
{
    public partial class Violation
    {
        public int ViolationId { get; set; }
        public ArrestType ArrestType { get; set; }
        public string Article { get; set; }
        public string Charge { get; set; }
        public ViolationType ViolationType { get; set; }

        public Incident Incident { get; set; }
    }
    public enum ArrestType
    {
        Unknown = 0, Marked_Patrol, Unmarked_Patrol, Marked_VASCAR, Unmarked_VASCAR,
        Marked_Stationary_Radar, Unmarked_Stationary_Radar, Marked_Moving_Radar_Stationary,
        Unmarked_Moving_Radar_Stationary, Marked_Moving_Radar_Moving,
        Unmarked_Moving_Radar_Moving, Aircraft_Assist, Motorcycle, Marked_Off_Duty,
        Unmarked_Off_Duty, Foot_Patrol, Mounted_Patrol, Marked_Laser, Unmarked_Laser,
        License_Plate_Recognition
    }
    public enum ViolationType { Unknown = 0, Citation = 1, Warning = 2 }
}