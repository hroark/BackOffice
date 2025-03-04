using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BackOffice.Models.Codes
{
    public class Codes_Run
    {
        [Key]
        public int Code { get; set; }
        public string Description { get; set; }

        public Codes_Run() { }
        public Codes_Run(int code, string descpt)
        {
            Code = code;
            Description = descpt;
        }
        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{Code} {Description}";
        }


    }

    //public class Codes_Run_Dict : Dictionary<string, Codes_Run>
    //{
    //    public Codes_Run_Dict(string connectionString, string plant)
    //    {
    //        DataTable _runCodes;

    //        if (connectionString == DataBaseMaster.PlantConnectionString)
    //            _runCodes = DataHelper.ExecuteProc("Abattoir.GetRunCodesByPlant", new ProcParams("plant", plant), connectionString);
    //        else
    //            _runCodes = DataHelper.ExecuteProc("Abattoir.GetRunCodesByPlant_Local", new ProcParams("plant", plant), connectionString);

    //        foreach (DataRow _runRow in _runCodes.Rows)
    //        {
    //            Codes_Run _item = new Codes_Run
    //            {
    //                Code = _runRow.Field<byte>("Code"),
    //                Description = _runRow.Field<string>("Description")
    //            };


    //            Add(_item.Code.ToString(), _item);

    //        }

    //    }
    //}
}

