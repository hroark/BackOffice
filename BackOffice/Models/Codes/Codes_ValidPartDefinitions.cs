using System.Collections.Generic;
using System.Data;
using AFG.DataCollection.Common;
using AFG.DataCollection.Core;

namespace BackOffice.Models.Codes
{
    public class Codes_ValidPartDefinitions
    {
        public byte ReasonCode { get; set; }
        public byte PartCode { get; set; }
        public bool ValidCombination { get; set; }

    }

    //public class Codes_ValidPartDefinitions_List : List<Codes_ValidPartDefinitions>
    //{
    //    public Codes_ValidPartDefinitions_List(string plant)
    //    {
    //        DataTable _table = DataHelper.ExecuteProc("Abattoir.Codes_SelectAll_ValidCondemnReasonPartCombinations", new ProcParams("plant", plant), DataBaseMaster.PlantConnectionString);

    //        foreach (DataRow _row in _table.Rows)
    //        {
    //            Codes_ValidPartDefinitions _item = new Codes_ValidPartDefinitions
    //            {
    //                ReasonCode = _row.Field<byte>("ReasonCode"),
    //                PartCode = _row.Field<byte>("PartCode"),
    //                ValidCombination = _row.Field<bool>("ValidCombination")
    //            };

    //            Add(_item);
    //        }
    //    }
    //}
}
