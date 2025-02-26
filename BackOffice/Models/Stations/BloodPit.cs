using BackOffice.Models.Codes;

namespace BackOffice.Models.Stations
{
    /// <summary>
    /// Represents the Blood Pit station transactions
    /// </summary>
    public class BloodPit
    {
        public required string HouseTag1 { get; set; }
        public string? GeneratedHouseTag { get; set; }
        public string? BackTag { get; set; }
        public string? EarTag { get; set; }
        public required Codes_Breed Breed { get; set; }
        public Codes_Gender? Gender { get; set; }
        public int Lot_No { get; set; }
    }
}
