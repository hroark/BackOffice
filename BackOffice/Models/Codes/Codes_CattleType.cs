using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BackOffice.Models.Codes
{
    public class Codes_CattleType
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }


    }

    public class Codes_CattleType_Dict : Dictionary<string, Codes_CattleType>
    {
        public Codes_CattleType_Dict(string plant)
        {
            //DataTable _cattleTypes = DatabaseActions.ExecuteProc("Abattoir.Codes_CattleTypes_Select_V2", new ProcParams("Plant",int.Parse(plant)),DataBaseMaster.AbattoirLocalExpressDb());

            //foreach (DataRow _customHarvestRow in _cattleTypes.Rows)
            //{
            //    Codes_CattleType _item = new Codes_CattleType()
            //    {
            //        Code = _customHarvestRow.Field<string>("Code"),
            //        Description = _customHarvestRow.Field<string>("Description")
            //    };


            //    Add(_item.Code, _item);

            //}
        }
    }
}
