using BackOffice.Models.Codes;
using System.Data;

namespace BackOffice.Models.Stations
{
    public class LotStation
    {
        public short LotNumber { get; set; }
        public int HeadCount { get; set; }
        public int? BullCount { get; set; }
        public int? CowCount { get; set; }
        public int? SteerCount { get; set; }
        public int? DairyCount { get; set; }
        public string? Producer { get; set; }
        public required Codes_Cool Cool { get; set; }
        public required Codes_Age Age { get; set; }
        public required Codes_CustomHarvest CustomHarvest { get; set; }
        public required Codes_MudScore MudScore { get; set; }
        public bool? PlantNotified { get; set; }
        public required string CattleType { get; set; }
        public required string UnloadTime { get; set; }
        public required string RestrainerTime { get; set; }
        public int? EditReason { get; set; }
        public List<string>? ReceivingNumbers { get; set; }
        public bool? Fats { get; set; }
        public bool? BadLot { get; set; }
        public string? Buy { get; set; }
    }
}
