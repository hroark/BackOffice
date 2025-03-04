using Microsoft.EntityFrameworkCore;

namespace BackOffice.Models.Codes
{
    [PrimaryKey("Code", "PlantCode")]
    public class Codes_Gender
    {
        public required string Code { get; set; }
        public required string PlantCode { get; set; }
        public string? Description { get; set; }
        public required string AS400 { get; set; }


        public override string ToString()
        {
            return $"{Description}";
        }
    }

    //public class Codes_Gender_Dict : Dictionary<string, Codes_Gender>
    //{
    //    public Codes_Gender_Dict(string plant)
    //    {

    //        //DataTable _genderCodes = DataHelper.ExecuteProc("Abattoir.Codes_Gender_Select", new ProcParams("plant", plant), DataBaseMaster.AbattoirLocalExpressDb());

    //        //foreach (DataRow _row in _genderCodes.Rows)
    //        //{
    //        //    Codes_Gender _item = new Codes_Gender
    //        //    {
    //        //        Code = _row.Field<string>("Code"),
    //        //        Description = _row.Field<string>("Description")
    //        //    };

    //        //    Add(_item.Code.ToUpper(), _item);

    //        //}
    //    }
    //}
}
