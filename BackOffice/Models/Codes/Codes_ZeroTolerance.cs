using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AFG.DataCollection.Common;
using AFG.DataCollection.Core;

namespace BackOffice.Models.Codes
{
    public class Codes_ZeroTolerance
    {
        public byte Code { get; set; }
        public string Description { get; set; }
        public string ScanString { get; set; }
        public override string ToString()
        {
            return Description;
        }
    }

    /// <summary>
    /// contains a dictionary of the description and scan string of Test cases
    /// </summary>
    public class Codes_ZeroTolerance_Dict : Dictionary<string, Codes_ZeroTolerance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Codes_ZeroTolerance"/> class.
        /// </summary>
        public Codes_ZeroTolerance_Dict(string plant)
        {
            DataTable ZTCodes = DataHelper.ExecuteProc("Abattoir.Codes_ZeroTolerance_Select", new ProcParams("plant", plant));

            foreach (DataRow dr in ZTCodes.Rows)
            {
                Codes_ZeroTolerance _item = new Codes_ZeroTolerance()
                {
                    Code = dr.Field<byte>("Code"),
                    Description = dr.Field<string>("Description"),
                    ScanString = dr.Field<string>("ScanString")
                };

                Add(_item.ScanString, _item);
            }
        }
    }
}
