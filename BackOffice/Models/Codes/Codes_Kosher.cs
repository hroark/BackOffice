using System.Collections.Generic;

namespace BackOffice.Models.Codes
{
    public class Codes_Kosher
    {
        public string ScanString { get; set; }
        public string Description { get; set; }
        public byte Value { get; set; }

        public override string ToString()
        {
            return $"{Description}";
        }

        public Codes_Kosher(string ss, string d, byte v)
        {
            ScanString = ss;
            Description = d;
            Value = v;
        }

    }

    public class Codes_Kosher_Dict : Dictionary<string, Codes_Kosher>
    {
        public Codes_Kosher_Dict()
        {

            Add("Y", new Codes_Kosher("Y", "Kosher", 1));
            Add("N", new Codes_Kosher("N", "Not Kosher", 0));

        }

    }

}
