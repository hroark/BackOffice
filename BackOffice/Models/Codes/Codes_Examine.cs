using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AFG.DataCollection.Common;

namespace BackOffice.Models.Codes
{
    public class Codes_Examine
    {
        public byte Code { get; set; }
        public string Description { get; set; }
        public string ScanString { get; set; } 
        public bool Pass { get; set; } 

        public override string ToString()
        {
            return Description;
        }
    }

    public class Codes_Examine_Dict : Dictionary<string, Codes_Examine>
    {
        public Codes_Examine_Dict(string plant, ExamineType type)
        {
            string storedProc = type == ExamineType.ZeroTolerance ? "Abattoir.Codes_ZeroTolerance_Select" : "Abattoir.Codes_SRM_Select";

            DataTable table = DataHelper.ExecuteProc(storedProc, new ProcParams("plant", plant));

            foreach(DataRow dr in table.Rows)
            {
                Codes_Examine examine = new Codes_Examine()
                {
                    Code = dr.Field<byte>("Code"),
                    Description = dr.Field<string>("Description"),
                    ScanString = dr.Field<string>("ScanString"),
                    Pass = dr.Field<bool>("Pass")
                };

                Add(examine.ScanString, examine);
            }
        }
    }
}
