using System.ComponentModel.DataAnnotations;

namespace BackOffice.Models.Codes
{
    /// <summary>
    /// Cattle breeds description and scan string
    /// </summary>
    public class Codes_Buy
    {
        [Key]
        public string code { get; set; }
        [Key]
        public string PlantCode { get; set; }
        public string Description { get; set; }


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