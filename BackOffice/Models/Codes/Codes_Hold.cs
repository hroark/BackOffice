using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BackOffice.Models.Codes
{
    public enum HoldScreenType
    {
        OnHold,
        Release
    }

    public class Codes_Hold
    {
        [Key]
        public required string ScanString { get; set; }
        [Key]
        public required string PlantCode {get;set; }
        public string? Description { get; set; }
        public required string AS400 { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", ScanString, Description);
        }
    }

   // public class Codes_Hold_Dict : Dictionary<string, Codes_Hold>
   // {

        //public Codes_Hold_Dict(HoldScreenType screentype, string plant, string connection)
        //{

        //    DataTable _holdCodes;
        //    switch (screentype)
        //    {
        //        case HoldScreenType.Release:
        //            _holdCodes = DataHelper.ExecuteProc("Abattoir.Codes_Hold_Select_ReleaseHold_v2", new ProcParams("Plant", plant), connection);
        //            break;

        //        default: //HoldScreenType.OnHold
        //            _holdCodes = DataHelper.ExecuteProc("Abattoir.Codes_Hold_Select_PutOnHold_v2", new ProcParams("Plant", plant), connection);
        //            break;
        //    }


        //    foreach (DataRow _holdRow in _holdCodes.Rows)
        //    {
        //        Codes_Hold _item = new Codes_Hold
        //        {
        //            ScanString = _holdRow.Field<string>("ScanString"),
        //            Description = _holdRow.Field<string>("Description")
        //        };


        //        Add(_item.ScanString, _item);

        //    }

        //}
   //}

}

