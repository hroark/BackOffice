using BackOffice.Models.Codes;

namespace BackOffice.Models.Stations
{
    /// <summary>
    /// Represents the Viscera Condemn Station
    /// </summary>
    public class VisceraCondemn
    {
        public int HouseTag2 { get; set; }
        public Codes_Products VisceraPart { get; set; }
        public Codes_Reasons Reason { get; set; }
        public bool? IsSlunk { get; set; }
    }
}

