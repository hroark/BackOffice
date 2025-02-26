using System.Collections.Generic;

namespace BackOffice.Models.Codes
{
    public class Codes_Halal
    {
        public string ScanString { get; set; }
        public string Description { get; set; }
        public bool Value { get; set; }
              
        public Codes_Halal(string ss, string d, bool v)
        {
            ScanString = ss;
            Description = d;
            Value = v;
        }
    }

    public class Codes_Halal_Dict : Dictionary<string, Codes_Halal>
    {
        public Codes_Halal_Dict()
        {
            Add("H", new Codes_Halal("H", "Halal", true));
            Add("T", new Codes_Halal("L", "Not Halal", false));
        }
    }
}
