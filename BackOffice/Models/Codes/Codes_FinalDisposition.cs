using System.ComponentModel.DataAnnotations;

namespace BackOffice.Models.Codes
{
    public class Codes_FinalDisposition
    {
        [Key]
        public required string ScanString { get; set; }
        [Key]
        public required string PlantCode { get; set; }
        public required string Description { get; set; }
        public bool Pass { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }

    //public class Codes_FinalDisposition_Dict : Dictionary<string, Codes_FinalDisposition>
    //{
    //    public Codes_FinalDisposition_Dict(string plant)
    //    {
    //        DataTable dt = DatabaseActions.ExecuteProcedure("Abattoir.Codes_FinalDisposition_Select", new Dictionary<string,Object> parameters("plant", plant));

    //        foreach (DataRow dr in dt.Rows)
    //        {
    //            Codes_FinalDisposition finalDisposition = new Codes_FinalDisposition
    //            {
    //                Pass = dr.Field<bool>("Pass"),
    //                Description = dr.Field<string>("Description"),
    //                ScanString = dr.Field<string>("ScanString")
    //            };

    //            Add(finalDisposition.ScanString, finalDisposition);
    //        }
    //    }
    //}
}
