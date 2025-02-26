using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using AFG.DataCollection.Common;

namespace BackOffice.Models.Codes
{
    public class Codes_FinalDisposition
    {
        public string ScanString { get; set; }
        public string Description { get; set; }
        public string Plant { get; set; }
        public bool Pass { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }

    public class Codes_FinalDisposition_Dict : Dictionary<string, Codes_FinalDisposition>
    {
        public Codes_FinalDisposition_Dict(string plant)
        {
            DataTable dt = DataHelper.ExecuteProc("Abattoir.Codes_FinalDisposition_Select", new ProcParams("plant", plant));

            foreach (DataRow dr in dt.Rows)
            {
                Codes_FinalDisposition finalDisposition = new Codes_FinalDisposition
                {
                    Pass = dr.Field<bool>("Pass"),
                    Description = dr.Field<string>("Description"),
                    ScanString = dr.Field<string>("ScanString")
                };

                Add(finalDisposition.ScanString, finalDisposition);
            }
        }
    }
}
