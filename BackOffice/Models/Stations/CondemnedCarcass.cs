using BackOffice.Models.Codes;

public class CondemnedCarcass
{
    public CondemnedCarcass()
    { }
    public required int HouseTaq2 { get; set; }
    public required int RetainingNumber { get; set; }
    public Codes_Grade CondemnedGrade { get; set; }
    public Codes_CondemnReason CondemnedReason { get; set; }
    
}
