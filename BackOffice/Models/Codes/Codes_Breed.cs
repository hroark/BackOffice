using System.ComponentModel.DataAnnotations;

namespace BackOffice.Models.Codes
{
    /// <summary>
    /// Cattle breeds description and scan string
    /// </summary>
    public class Codes_Breed
    {
        [Key]
        public string ScanString { get; set; }
        [Key]
        public string PlantCode { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance. in the form of 'scanString - description'
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{ScanString.Trim()} - {Description}";
        }
    }

    /// <summary>
    /// contains a dictionary of the description and scan string of cattle breeds
    /// </summary>
    public class Codes_Breed_Dict : Dictionary<string, Codes_Breed>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Codes_Breed_Dict"/> class.
        /// </summary>
        public Codes_Breed_Dict(string plant)
        {
            //DataTable _cattleCodes = DataHelper.ExecuteProc("Abattoir.Codes_Breed_Select_V2", new ProcParams("plant", plant), DataBaseMaster.AbattoirLocalExpressDb());

            //foreach (DataRow _cattleRow in _cattleCodes.Rows)
            //{
            //    Codes_Breed _item = new Codes_Breed
            //    {
            //        ScanString = _cattleRow.Field<string>("ScanString"),
            //        Description = _cattleRow.Field<string>("Description")
            //    };

            //    Add(_item.ScanString.Trim().ToUpper(), _item);
            //}
        }
    }
}