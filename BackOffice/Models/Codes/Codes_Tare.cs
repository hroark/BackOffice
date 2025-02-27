using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BackOffice.Models.Codes
{
    [PrimaryKey("ScanString", "PlantCode")]
    public class Codes_Tare
    {
        public required string ScanString { get; set; }
        public required string PlantCode { get; set; }
        public required string Description { get; set; }
        public decimal Weight { get; set; }

        public override string ToString()
        {
            return $"{Description}";
        }
    }



    //public class Codes_Tare_Dict : Dictionary<string, Codes_Tare>
    //{
    //    public Codes_Tare_Dict(string plant)
    //    {

    //        DataTable _tareCodes = DataHelper.ExecuteProc("[Abattoir].[Codes_Tare_Select]", new ProcParams("Plant",plant,DataBaseMaster.PlantConnectionString));

    //        foreach (DataRow _tareRow in _tareCodes.Rows)
    //        {
    //            Codes_Tare _item = new Codes_Tare
    //            {
    //                ScanString = _tareRow.Field<string>("ScanString"),
    //                Description = _tareRow.Field<string>("Description"),
    //                Weight = _tareRow.Field<decimal>("Weight")
    //            };

    //            Add(_item.ScanString, _item);

    //        }


    //    }



    //}
}