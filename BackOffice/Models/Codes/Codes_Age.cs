using System.Collections.Generic;
using System.Data;


namespace BackOffice.Models.Codes
{
    public class Codes_Age
    {
        public string ScanString { get; set; }
        public string Description { get; set; }
        public short Code { get; set; }

        public override string ToString()
        {
            return $"{Description}";
        }

    }

    public class Codes_Age_Dict : Dictionary<string, Codes_Age>
    {
        public Codes_Age_Dict()
        {

            DataTable _ageCodes = DataHelper.ExecuteProc("Abattoir.Codes_Age_Select", null, DataBaseMaster.AbattoirLocalExpressDb());

            foreach (DataRow _ageRow in _ageCodes.Rows)
            {
                Codes_Age _item = new Codes_Age
                {
                    ScanString = _ageRow.Field<string>("ScanString"),
                    Description = _ageRow.Field<string>("Description"),
                    Code = _ageRow.Field<byte>("Code")
                };

                Add(_item.ScanString, _item);

            }


        }



    }
}
