using System.Data;

namespace BackOffice.Models.Codes
{
    public class Codes_Shift
    {
        public string ScanString { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Description);
        }
    }

    //public class Codes_Shift_Dict : Dictionary<string, Codes_Shift>
    //{
    //    public Codes_Shift_Dict()
    //        : this(DataBaseMaster.DefaultConnectionString)
    //    {

    //    }
    //    public Codes_Shift_Dict(string ConnectionString)
    //    {

    //        DataTable _shiftCodes = DataHelper.ExecuteProc("Abattoir.Codes_Shift_Select", null, ConnectionString);

    //        foreach (DataRow _shiftRow in _shiftCodes.Rows)
    //        {
    //            Codes_Shift _item = new Codes_Shift
    //            {
    //                ScanString = _shiftRow.Field<string>("ScanString"),
    //                Description = _shiftRow.Field<string>("Description")
    //            };


    //            Add(_item.ScanString, _item);

    //        }


    //    }



    //}
}
