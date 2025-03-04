using Microsoft.EntityFrameworkCore;

namespace BackOffice.Models.Codes
{
    /// <summary>
    /// Cattle breeds description and scan string
    /// </summary>
    [PrimaryKey("Code", "PlantCode")]
    public class Codes_Buy
    {
        public required string Code { get; set; }
        public required string PlantCode { get; set; }
        public required string Description { get; set; }
        

        public override string ToString()
        {
            return Description;
        }
    }

    ///// <summary>
    ///// contains a dictionary of the description and scan string of cattle breeds
    ///// </summary>
    //public class Codes_Buy_Dict : Dictionary<string, Codes_Buy>
    //{
    //    /// <summary>
    //    /// Initializes a new instance of the <see cref="Codes_Buy_Dict"/> class.
    //    /// </summary>
    //    public Codes_Buy_Dict()
    //    {
    //        DataTable BuyCodes = DataHelper.ExecuteProc("Abattoir.Codes_Buy_Select");

    //        foreach (DataRow dr in BuyCodes.Rows)
    //        {
    //            Codes_Buy _item = new Codes_Buy()
    //            {
    //                Description = dr.Field<string>("Description"),
    //                code = dr.Field<string>("Code")
    //            };

    //            Add(_item.code, _item);
    //        }
    //    }
    //}
}