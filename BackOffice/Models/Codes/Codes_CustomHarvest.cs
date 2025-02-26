﻿using System.Collections.Generic;
using System.Data;

namespace BackOffice.Models.Codes
{
    public class Codes_CustomHarvest
    {
        private string _plant;
        public string ScanString { get; set; }
        public string Description { get; set; }
        public string Plant { get; set; }

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
