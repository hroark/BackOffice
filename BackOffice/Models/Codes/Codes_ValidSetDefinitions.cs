using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AFG.DataCollection.Common;
using AFG.DataCollection.Core;

namespace BackOffice.Models.Codes
{
    public class Codes_ValidSetDefinitions
    {

        public byte ReasonCode { get; set; }
        public byte SetCode { get; set; }
        public bool ValidCombination { get; set; }

    }

    //public class Codes_ValidSetDefinitions_List : List<Codes_ValidSetDefinitions>
    //{
    //    public Codes_ValidSetDefinitions_List(string plant)
    //    {
    //        DataTable _table = DataHelper.ExecuteProc("Abattoir.Codes_SelectAll_ValidCondemnReasonSetCombinations", new ProcParams("plant", plant), DataBaseMaster.PlantConnectionString);

    //        foreach (DataRow _row in _table.Rows)
    //        {
    //            Codes_ValidSetDefinitions _item = new Codes_ValidSetDefinitions
    //            {
    //                ReasonCode = _row.Field<byte>("ReasonCode"),
    //                SetCode = _row.Field<byte>("SetCode"),
    //                ValidCombination = _row.Field<bool>("ValidCombination")
    //            };


    //            Add(_item);
    //        }
    //    }
    //}
}
