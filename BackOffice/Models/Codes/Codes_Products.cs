using System.Data;

namespace BackOffice.Models.Codes
{
    public class Codes_Products
    {
        public byte Code { get; set; }
        public string ScanString { get; set; }
        public string Description { get; set; }
        public DataTable ProductTable { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }

    //public class Codes_Products_Dict : Dictionary<string, Codes_Products>
    //{
    //    public DataTable ProductDataTable { get; set; }

    //    public Codes_Products_Dict(string plant)
    //    {
    //        ProductDataTable = DataHelper.ExecuteProc("Abattoir.GetVisceraParts", new ProcParams("plant", plant), DataBaseMaster.AbattoirLocalExpressDb());

    //        foreach (DataRow _row in ProductDataTable.Rows)
    //        {
    //            Codes_Products Item = new Codes_Products
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
