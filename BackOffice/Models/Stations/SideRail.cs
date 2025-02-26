namespace BackOffice.Models.Stations
{
    /// <summary>
    /// Each of these gets sent up PER Reason Code
    /// </summary>
    public class SideRail
    {
        public int HouseTag2 { get; set; }
        public int CarcassHalf{ get; set; }
        public int ReasonCode { get; set; }
        public int StationIdentifier { get; set; }
        public int TrimCode { get; set; }
    }
}
