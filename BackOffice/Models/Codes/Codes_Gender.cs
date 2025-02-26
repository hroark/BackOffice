using System.Collections.Generic;
using System.Data;
using AFG.DataCollection.Common;
using AFG.DataCollection.Core;

namespace BackOffice.Models.Codes
{
    public class Codes_Gender
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Description}";
        }
    }

    public class Codes_Gender_Dict : Dictionary<string, Codes_Gender>
    {
        public Codes_Gender_Dict(string plant)
        {

            DataTable _genderCodes = DataHelper.ExecuteProc("Abattoir.Codes_Gender_Select", new ProcParams("plant", plant), DataBaseMaster.AbattoirLocalExpressDb());

            foreach (DataRow _row in _genderCodes.Rows)
            {
                Codes_Gender _item = new Codes_Gender
                {
                    Code = _row.Field<string>("Code"),
                    Description = _row.Field<string>("Description")
                };

                Add(_item.Code.ToUpper(), _item);

            }
        }
    }
}
