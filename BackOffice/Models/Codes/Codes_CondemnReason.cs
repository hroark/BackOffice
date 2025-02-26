﻿using System.Collections.Generic;
using System.Data;
using AFG.DataCollection.Common;
using AFG.DataCollection.Core;

namespace BackOffice.Models.Codes
{
    public class Codes_CondemnReason
    {
        public byte Code { get; set; }
        public string ScanString { get; set; }
        public string Description { get; set; }
        public string AS400 { get; set; }

        public override string ToString()
        {
            return Description;
        }

    }

    public enum CondemnScreenType
    {
        HeadTable,
        VisceraTable,
        Retain,
        Carcass,
        SideTrim,
        SideInspection
    }


    public class Codes_CondemnReason_Dict : Dictionary<string, Codes_CondemnReason>
    {
        public Codes_CondemnReason_Dict(CondemnScreenType reasonType,string plant, bool needsPlant = false)
        {
            string _storedProcName = "";
          
            switch (reasonType)
            {
                case CondemnScreenType.HeadTable:
                    _storedProcName = "Abattoir.Codes_HeadReason_Select_V2";
                    break;
                case CondemnScreenType.VisceraTable:
                    _storedProcName = "Abattoir.Codes_VisceraReason_Select_V2";
                    break;
                case CondemnScreenType.Retain:
                    _storedProcName = "Abattoir.Codes_RetainReason_Select_V2";
                    break;
                case CondemnScreenType.Carcass:
                    _storedProcName = "Abattoir.Codes_CondemnCarcassReason_Select_V2";
                    
                    break;
                case CondemnScreenType.SideTrim:
                    _storedProcName = "Abattoir.Codes_SideTrim_Select_V2";
                    break;
                case CondemnScreenType.SideInspection:
                    _storedProcName = "Abattoir.Codes_SideInspection_Select_V2";
                    break;
            }

            DataTable _table = new DataTable();
              if (!needsPlant )
               _table = DataHelper.ExecuteProc(_storedProcName,DataBaseMaster.PlantConnectionString);
              else
              {
                  _table = DataHelper.ExecuteProc(_storedProcName,new ProcParams("Plant", plant),DataBaseMaster.PlantConnectionString);
              }

            foreach (DataRow _row in _table.Rows)
            {
                Codes_CondemnReason _item = new Codes_CondemnReason
                {
                    AS400 = _row.Field<string>("AS400"),
                    Code = _row.Field<byte>("Code"),
                    ScanString = _row.Field<string>("ScanString"),
                    Description = _row.Field<string>("Description")
                };


                Add(_item.ScanString, _item);

            }
        }

        public Codes_CondemnReason_Dict(CondemnScreenType reasonType,string plant)
        {
            string _storedProcName = "";
      
            switch (reasonType)
            {
                case CondemnScreenType.HeadTable:
                    _storedProcName = "Abattoir.Codes_HeadReason_Select_V2";
                    break;
                case CondemnScreenType.VisceraTable:
                    _storedProcName = "Abattoir.Codes_VisceraReason_Select_V2";
                    break;
                case CondemnScreenType.Retain:
                    _storedProcName = "Abattoir.Codes_RetainReason_Select_V3";
                    break;
                case CondemnScreenType.Carcass:
                    _storedProcName = "Abattoir.Codes_CondemnCarcassReason_Select_V2";
                    break;
                case CondemnScreenType.SideTrim:
                    _storedProcName = "Abattoir.Codes_SideTrim_Select_V2";
                    break;
                case CondemnScreenType.SideInspection:
                    _storedProcName = "Abattoir.Codes_SideInspection_Select_V2";
                    break;
            }

            DataTable _table = DataHelper.ExecuteProc(_storedProcName,new ProcParams("Plant",plant), DataBaseMaster.AbattoirLocalExpressDb());

            foreach (DataRow _row in _table.Rows)
            {
                Codes_CondemnReason _item = new Codes_CondemnReason
                {
                    AS400 = _row.Field<string>("AS400"),
                    Code = _row.Field<byte>("Code"),
                    ScanString = _row.Field<string>("ScanString"),
                    Description = _row.Field<string>("Description")
                };


                Add(_item.ScanString, _item);

            }
        }
    }


}
