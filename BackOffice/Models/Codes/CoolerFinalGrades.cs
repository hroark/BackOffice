using BackOffice.Models.Codes;
using System.Data;

namespace BackOffice.Models.Codes
{
    public class CoolerFinalGrades
    {
        public string FinalGrade { get; set; }
        public int HotGrade { get; set; }
        public int RunCode { get; set; }

        public override string ToString()
        {
            return $"{FinalGrade}";
        }

    }


//public class Codes_Cooler_Grading_Dict : Dictionary<CoolerFinalGrades, int>
//{
   // public Codes_Cooler_Grading_Dict(string plant)
    //{
        //DataTable _coolerGradingCodes =
        //    DataHelper.ExecuteProc("Abattoir.Codes_CGrades_Get", new ProcParams("plant", plant), DataBaseMaster.PlantConnectionString);

        //foreach (DataRow _cgradeRow in _coolerGradingCodes.Rows)
        //{
        //    CoolerFinalGrades _item = new CoolerFinalGrades
        //    {
        //        FinalGrade = _cgradeRow.Field<int>("FinalGrade").ToString(),
        //        HotGrade = _cgradeRow.Field<int>("HotGrade"),
        //        RunCode = _cgradeRow.Field<int>("RunCode")
        //    };


        //    Add(_item, _cgradeRow.Field<int>("FinalGrade"));
       // }
    //}
}