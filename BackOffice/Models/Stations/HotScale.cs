using BackOffice.Models.Codes;

namespace BackOffice.Models.Stations
{
    /// <summary>
    /// Represents the Hot Scale Station
    /// </summary>
    public class HotScale
    {
        public required string HouseTag2 { get; set; }
        public required string HouseTag3 { get; set; }

        public Codes_Cool? Cool { get; set; }
        public Codes_Age? Age { get; set; }
        public required Codes_Grade HotGrade { get; set; }
        public Codes_Kosher? Kosher { get; set; }
        public Codes_Trim? Trim { get; set; }
        public required decimal GrossWeight { get; set; }
        public required decimal TareWeight { get; set; }
        public short? CarcassHalf { get; set; }
    }
}
