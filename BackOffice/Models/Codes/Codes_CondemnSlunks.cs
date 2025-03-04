using System.ComponentModel.DataAnnotations;
using System.Data;
using AFG.DataCollection.Common;
using AFG.DataCollection.Core;

namespace BackOffice.Models.Codes
{
    public class Codes_CondemnSlunks
    {
        [Key]
        public byte Code { get; set; }
        public required string ScanString { get; set; }
        public required string Description { get; set; }
        public required string AS400 { get; set; }
        


        public override string ToString()
        {
            return Description;
        }
    }

    //public class Codes_CondemnSlunks_Dict : Dictionary<string, Codes_CondemnSlunks>
    //{
    //    public DataTable SlunkDataTable { get; set; }

    //    public Codes_CondemnSlunks_Dict()
    //    {
    //        //SlunkDataTable = DatabaseActions.ExecuteProcedure("Abattoir.GetVisceraSlunks");

    //        //foreach (DataRow _row in SlunkDataTable.Rows)
    //        //{
    //        //    Codes_CondemnSlunks Item = new Codes_CondemnSlunks
    //        //    {
    //        //        Code = _row.Field<byte>("Code"),
    //        //        ScanString = _row.Field<string>("ScanString"),
    //        //        Description = _row.Field<string>("Description")
    //        //    };

    //        //    Add(Item.ScanString, Item);

    //        //}
    //    }
    //}
}
