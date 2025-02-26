using System.Data;

namespace BackOffice.Models.Codes
{
    public class Codes_Grade
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

        public string Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Codes_Grade"/> class.
        /// </summary>
        public Codes_Grade() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Codes_Grade"/> class.
        /// </summary>
        /// <param name="code">The grade code.</param>
        /// <param name="descpt">The description of the code.</param>
        public Codes_Grade(int code, string descpt, string scanString)
        {
            Code = code;
            Description = descpt;
            ScanString = scanString;
            Abbreviation = string.Empty;

        }
        public Codes_Grade(int code, string descpt, string scanString, string abbreviation)
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

    }

    public class Codes_Grade_Dict : Dictionary<string, Codes_Grade>
    {

        public void Load_HotScale(char? Gender, string plant)
        {
            Load("Abattoir.Grades_HotScaleSelect_Local", plant, Gender);
        }
        public void Load_HotScale(string plant, string connectionString, bool isLocal)
        {
            Load("Abattoir.Grades_HotScaleSelect", plant, connectionString);
        }

        public void Load_Condemned()
        {


            Clear();
            DataTable _codesGrade;


            DataTable _gradeCodes = DatabaseActions.ExecuteProcedure("Abattoir.Grades_Select_Condemn_Active", new Dictionary<string, string>());
            _codesGrade = _gradeCodes;

            foreach (DataRow _gradeRow in _codesGrade.Rows)
            {
                Codes_Grade _item = new Codes_Grade
                {
                    Code = _gradeRow.Field<byte>("GradeCode"),
                    Description = _gradeRow.Field<string>("Description"),
                    ScanString = _gradeRow.Field<string>("ScanString"),
                    // Abbreviation = _gradeRow.Field<string>("Abbreviation"),
                };

                Add(_item.ScanString.ToUpper(), _item);

            }

        }

        private void Load(string storedProc, string plant, char? genderParm = null)
        {
            //Clear();
            //DataTable _codesGrade;
            //if (plant.Length == 1)
            //{
            //    plant = "0" + plant;
            //}
            //if (genderParm != null)
            //{
            //    DataTable _gradeCodes = DataHelper.ExecuteProc(storedProc, new ProcParams("Gender", genderParm, "Plant", plant), _localConnection);
            //    _codesGrade = _gradeCodes;
            //}
            //else
            //{
            //    DataTable _gradeCodes = DataHelper.ExecuteProc(storedProc, new ProcParams("Plant", plant), _localConnection);
            //    _codesGrade = _gradeCodes;
            //}


            //foreach (DataRow _gradeRow in _codesGrade.Rows)
            //{
            //    Codes_Grade _item = new Codes_Grade
            //    {
            //        Code = _gradeRow.Field<byte>("GradeCode"),
            //        Description = _gradeRow.Field<string>("Description"),
            //        ScanString = _gradeRow.Field<string>("ScanString"),
            //        Abbreviation = _gradeRow.Field<string>("Abbreviation"),
            //    };

            //    Add(_item.ScanString.ToUpper(), _item);

            }

        //}

        private void Load(string storedProc, string plant, string connectionString)
        {
            //Clear();
            //DataTable _codesGrade;
            //if (plant.Length == 1)
            //{
            //    plant = "0" + plant;
            //}
            //DataTable _gradeCodes = DataHelper.ExecuteProc(storedProc, connectionString);
            //_codesGrade = _gradeCodes;



            //foreach (DataRow _gradeRow in _codesGrade.Rows)
            //{
            //    Codes_Grade _item = new Codes_Grade
            //    {
            //        Code = _gradeRow.Field<byte>("GradeCode"),
            //        Description = _gradeRow.Field<string>("Description"),
            //        ScanString = _gradeRow.Field<string>("ScanString")
            //    };

            //    Add(_item.ScanString.ToUpper(), _item);

            //}

        }


    }

}
