using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BackOffice.Models.Codes
{
    [PrimaryKey("ScanString", "PlantCode")]
    public class Codes_Trim
    {
        public required string ScanString { get; set; }
        public required string PlantCode { get; set; }
        public required string Description { get; set; }
        public required string AS400 { get; set; }

        public override string ToString()
        {
            return $"{ScanString} {Description}";
        }
    }

    //public class Codes_Trim_Dict : Dictionary<string, Codes_Trim>
    //{

    //    public Codes_Trim_Dict(string plant)
    //    {

    //        DataTable TrimCodes = DataHelper.ExecuteProc("Abattoir.Codes_Trim_Select_v2", new ProcParams("plant", plant), DataBaseMaster.AbattoirLocalExpressDb());

    //        foreach (DataRow TrimRow in TrimCodes.Rows)
    //        {
    //            Codes_Trim Item = new Codes_Trim();

    //            Item.ScanString = TrimRow.Field<string>("ScanString").Trim();
    //            Item.Description = TrimRow.Field<string>("Description");
    //            Item.AS400 = TrimRow.Field<string>("AS400");

    //            Add(Item.ScanString.Trim(), Item);

    //        }

    //    }

    //public Codes_Trim_Dict(string plant, bool inPlant = false)
    //{
    //    DataTable TrimCodes;

    //    if (!inPlant)
    //    {
    //        TrimCodes = DataHelper.ExecuteProc("Abattoir.Codes_Trim_Select_v2", new ProcParams("plant", plant), DataBaseMaster.AbattoirLocalExpressDb());

    //        foreach (DataRow TrimRow in TrimCodes.Rows)
    //        {
    //            Codes_Trim Item = new Codes_Trim();

    //            Item.ScanString = TrimRow.Field<string>("ScanString").Trim();
    //            Item.Description = TrimRow.Field<string>("Description");
    //            Item.AS400 = TrimRow.Field<string>("AS400");

    //            Add(Item.ScanString.Trim(), Item);

    //        }
    //    }
    //    else
    //    {
    //        TrimCodes = DataHelper.ExecuteProc("Abattoir.Codes_Trim_Select_v2", new ProcParams("plant", plant), DataBaseMaster.PlantConnectionString);

    //        foreach (DataRow TrimRow in TrimCodes.Rows)
    //        {
    //            Codes_Trim Item = new Codes_Trim();

    //            Item.ScanString = TrimRow.Field<string>("ScanString").Trim();
    //            Item.Description = TrimRow.Field<string>("Description");
    //            Item.AS400 = TrimRow.Field<string>("AS400");

    //            Add(Item.ScanString.Trim(), Item);

    //        }
    //    }



    //}

    //  }

}
