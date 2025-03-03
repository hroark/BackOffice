﻿using System.ComponentModel.DataAnnotations;
using System.Data;
using AFG.DataCollection.Common;
using AFG.DataCollection.Core;

namespace BackOffice.Models.Codes
{
    public class Codes_CondemnProduct
    {
        [Key]
        public byte Code { get; set; }
        [Key]
        public string PlantCode { get; set; }
        public string ScanString { get; set; }
        public string Description { get; set; }
        public string AS400 { get; set; }
       

        public override string ToString()
        {
            return Description;
        }

    }

    //public class Codes_CondemnProduct_Dict : Dictionary<string, Codes_CondemnProduct>
    //{
    //    public Codes_CondemnProduct_Dict(CondemnScreenType reasonType, string plant)
    //    {
    //        //DataTable _table = null;

    //        //switch (reasonType)
    //        //{
    //        //    case CondemnScreenType.HeadTable:
    //        //        _table = DatabaseActions.ExecuteProcedure("Abattoir.Codes_HeadProduct_Select", new ProcParams("plant", plant), DataBaseMaster.PlantConnectionString);
    //        //        break;

    //        //    case CondemnScreenType.VisceraTable:
    //        //        _table = DatabaseActions.ExecuteProcedure("Abattoir.Codes_VisceraProduct_Select",  DataBaseMaster.PlantConnectionString);
    //        //        break;
    //        //}

    //        //foreach (DataRow _row in _table.Rows)
    //        //{
    //        //    Codes_CondemnProduct Item = new Codes_CondemnProduct();

    //        //    Item.Code = _row.Field<byte>("Code");
    //        //    Item.ScanString = _row.Field<string>("ScanString");
    //        //    Item.Description = _row.Field<string>("Description");

    //        //    Add(Item.ScanString, Item);

    //        //}
    //    }
    //}


}
