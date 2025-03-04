using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AFG.DataCollection.Common;
using AFG.DataCollection.Core;

namespace BackOffice.Models.Codes
{
    public class Codes_ReasonPartCombinations
    {
        public byte ReasonCode { get; set; }
        public byte PartCode { get; set; }

    }

    //    public class Codes_ReasonPartCombinations_List : List<Codes_ReasonPartCombinations>
    //    {
    //        public Codes_ReasonPartCombinations_List(string plant)
    //        {
    //            DataTable _table = DataHelper.ExecuteProc("Abattoir.ReasonPartCombinations", new ProcParams("plant", plant));

    //            foreach (DataRow _row in _table.Rows)
    //            {
    //                Codes_ReasonPartCombinations _item = new Codes_ReasonPartCombinations
    //                {
    //                    ReasonCode = _row.Field<byte>("ReasonCode"),
    //                    PartCode = _row.Field<byte>("PartCode")
    //                };
    //                Add(_item);
    //            }
    //        }
    //    }
}
