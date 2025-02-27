using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BackOffice.Models.Codes
{
    public class Codes_CustomHarvest
    {
        [Key]
        public required string Plant { get; set; }
        [Key]
        public required string Code { get; set; }
        private string? AS400 {get;set; }
        public required string ScanString { get; set; }
        public required string Description { get; set; }


        public override string ToString()
        {
            return Description;
        }

    }

    //public class Codes_CustomHarvest_Dict : Dictionary<string, Codes_CustomHarvest>
    //{
    //    public Codes_CustomHarvest_Dict(string plant)
    //    {
    //        DataTable _customHarvestCodes = DatabaseActions.ExecuteProcedure("Abattoir.Codes_CustomHarvest_Select_V2", new Dictionary<string,string>;

    //        foreach (DataRow _customHarvestRow in _customHarvestCodes.Rows)
    //        {
    //            Codes_CustomHarvest _item = new Codes_CustomHarvest
    //            {
    //                // Code = _customHarvestRow.Field<byte>("Code"),
    //                ScanString = _customHarvestRow.Field<string>("ScanString"),
    //                Description = _customHarvestRow.Field<string>("Description")
    //            };


    //            Add(_item.ScanString, _item);

    //        }
    //    }
    //}
}
