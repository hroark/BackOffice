using System.Data;

namespace BackOffice.Models.Codes
{
    public class Codes_Grade_Plant
    {
        /// <summary>
        /// Gets or sets the Grade Code.
        /// </summary>
        /// <value>
        /// The Grade Code.
        /// </value>
        public int Code { get; set; }
        /// <summary>
        /// Gets or sets the long description.
        /// </summary>
        /// <value>
        /// The long description.
        /// </value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the scan string.
        /// </summary>
        /// <value>
        /// The scan string.
        /// </value>
        public string ScanString { get; set; }

        public string Abbreviation { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Codes_Grade"/> class.
        /// </summary>
        public Codes_Grade_Plant() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Codes_Grade"/> class.
        /// </summary>
        /// <param name="code">The grade code.</param>
        /// <param name="descpt">The description of the code.</param>
        public Codes_Grade_Plant(int code, string descpt, string scanString)
        {
            Code = code;
            Description = descpt;
            ScanString = scanString;
            Abbreviation = string.Empty;

        }
        public Codes_Grade_Plant(int code, string descpt, string scanString, string abbreviation)
        {
            Code = code;
            Description = descpt;
            ScanString = scanString;
            Abbreviation = abbreviation;

        }
        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0} ", Description);
        }

    

    //public class Codes_Grade_Plant_Dict : Dictionary<string, Codes_Grade_Plant>
    //{



    //    public Codes_Grade_Plant_Dict(string plant)
    //    {
    //        Load("Abattoir.Grades_HotScaleSelect_Mobile", plant);
    //    }



        //public void Load_Condemned()
        //{
  

        //    Clear();
        //    DataTable _codesGrade;


        //    DataTable _gradeCodes = DatabaseActions.ExecuteProcedure("Abattoir.Grades_Select_Condemn_Active", new Dictionary<string, string>());
        //    _codesGrade = _gradeCodes;

        //    foreach (DataRow _gradeRow in _codesGrade.Rows)
        //    {
        //        Codes_Grade_Plant _item = new Codes_Grade_Plant
        //        {
        //            Code = _gradeRow.Field<byte>("GradeCode"),
        //            Description = _gradeRow.Field<string>("Description"),
        //            ScanString = _gradeRow.Field<string>("ScanString"),
        //            // Abbreviation = _gradeRow.Field<string>("Abbreviation"),
        //        };

        //        Add(_item.ScanString.ToUpper(), _item);

        //    }

        //}

        //private void Load(string StoredProc, string plant)
        //{
        //    Clear();
        //    DataTable _codesGrade;
        //    if (plant.Length == 1)
        //    {
        //        plant = "0" + plant;
        //    }

        //    DataTable _gradeCodes = DatabaseActions.ExecuteProcedure(StoredProc, new Dictionary<string, string>());
        //    _codesGrade = _gradeCodes;



        //    foreach (DataRow _gradeRow in _codesGrade.Rows)
        //    {
        //        Codes_Grade_Plant _item = new Codes_Grade_Plant
        //        {
        //            Code = _gradeRow.Field<byte>("GradeCode"),
        //            Description = _gradeRow.Field<string>("Description"),
        //            ScanString = _gradeRow.Field<string>("ScanString"),
        //            //Abbreviation = _gradeRow.Field<string>("Abbreviation"),
        //        };

        //        Add(_item.ScanString.ToUpper(), _item);

        //    }

        //}
    }
}
