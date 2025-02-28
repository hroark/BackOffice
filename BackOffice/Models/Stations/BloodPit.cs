using BackOffice.DataStuff.Interfaces;
using BackOffice.Models.Codes;
using System.Text.Json;

namespace BackOffice.Models.Stations
{
    /// <summary>
    /// Represents the Blood Pit station transactions
    /// </summary>
    public class BloodPit : Base, ITransaction<BloodPit>
    {
        public required string HouseTag1 { get; set; }
        public string? GeneratedHouseTag { get; set; }
        public string? BackTag { get; set; }
        public string? EarTag { get; set; }
        public required Codes_Breed Breed { get; set; }
        public Codes_Gender? Gender { get; set; }
        public int Lot_No { get; set; }





        public void SaveToDatabase(BloodPit item)
        {
            throw new NotImplementedException();
        }

        public ITransaction<BloodPit> GetFromDatabase(int count)
        {
            throw new NotImplementedException();
        }

        public void ToJson()
        {
            JsonSerializer.Serialize(this);
        }
        public BloodPit FromJson()
        {
            return JsonSerializer.Deserialize<BloodPit>() ?? throw new InvalidOperationException("Json invalid for deserialization");
        }
    }
}
