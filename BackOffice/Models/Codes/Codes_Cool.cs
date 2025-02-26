using System.Collections.Generic;
using System.Data;
using AFG.DataCollection.Common;
using AFG.DataCollection.Core;

namespace BackOffice.Models.Codes
{
    public class Codes_Cool
    {
        public string ScanString { get; set; }
        public string Description { get; set; }

        public byte Code { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }

    public class Codes_Cool_Dict : Dictionary<string, Codes_Cool>
    {

        public Codes_Cool_Dict()
        {

            DataTable _coolCodes = DataHelper.ExecuteProc("Abattoir.Codes_COOL_Select", DataBaseMaster.AbattoirLocalExpressDb());


            foreach (DataRow _coolRow in _coolCodes.Rows)
            {
                //We are currently only using domestic and non-domestic
                if (_coolRow.Field<string>("ScanString") != "F" && _coolRow.Field<string>("ScanString") != "G")
                {
                    continue;
                }
                Codes_Cool _item = new Codes_Cool
                {
                    ScanString = _coolRow.Field<string>("ScanString"),
                    Description = _coolRow.Field<string>("Description"),
                    Code = _coolRow.Field<byte>("Code")
                };


                Add(_item.ScanString, _item);
            }
        }
    }
}