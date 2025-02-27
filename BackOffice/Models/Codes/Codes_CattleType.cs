using System.ComponentModel.DataAnnotations;

namespace BackOffice.Models.Codes
{
    public class Codes_CattleType
    {
        [Key]
        public required string Code { get; set; }
        [Key]
        public required string PlantCode { get; set; }
        public required string AS400 { get; set; }
        public required string Description { get; set; }


        public override string ToString()
        {
            return Description;
        }


    }

    //public class Codes_CattleType_Dict : Dictionary<string, Codes_CattleType>
    //{
    //    public Codes_CattleType_Dict(string plant)
    //    {
    //        //DataTable _cattleTypes = DatabaseActions.ExecuteProc("Abattoir.Codes_CattleTypes_Select_V2", new ProcParams("Plant",int.Parse(plant)),DataBaseMaster.AbattoirLocalExpressDb());

    //        //foreach (DataRow _customHarvestRow in _cattleTypes.Rows)
    //        //{
    //        //    Codes_CattleType _item = new Codes_CattleType()
    //        //    {
    //        //        Code = _customHarvestRow.Field<string>("Code"),
    //        //        Description = _customHarvestRow.Field<string>("Description")
    //        //    };


    //        //    Add(_item.Code, _item);

    //        //}
    //    }
    //}
}
