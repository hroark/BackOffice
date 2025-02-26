using BackOffice.Models.Codes;

namespace BackOffice.Models.Stations
{
    public class HidePuller
    {
        public required string HouseTag1 { get; set; }
        public required string HouseTag2 { get; set; }
        public Codes_Gender? Gender { get; set; }
        public Codes_Kosher? Kosher { get; set; }
    }
}
