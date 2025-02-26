using System.Data;

namespace BackOffice.Models.Codes
{
    public class Codes_Reasons
    {
        public byte Code { get; set; }
        public string ScanString { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }

    //public class Codes_Reason_Dict : Dictionary<string, Codes_Reasons>
    //{
    //    public DataTable ReasonDataTable { get; set; }
    //    public Codes_Reason_Dict()
    //    {
    //        ReasonDataTable = DataHelper.ExecuteProc("Abattoir.VisceraTableReasons", DataBaseMaster.AbattoirLocalExpressDb());

    //        foreach (DataRow _row in ReasonDataTable.Rows)
    //        {
    //            Codes_Reasons Item = new Codes_Reasons
    //            {
    //                Code = _row.Field<byte>("Code"),
    //                ScanString = _row.Field<string>("ScanString"),
    //                Description = _row.Field<string>("Description")
    //            };
    //            Add(Item.ScanString, Item);
    //        }
    //    }
    //}
}
