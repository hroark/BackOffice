using System.Collections.Generic;
using System.Data;
using System.Drawing;
using AFG.DataCollection.Common;
using AFG.DataCollection.Core;

namespace BackOffice.Models.Codes
{
    public class Codes_SRM
    {
        public byte Code { get; set; }  
        public string Description { get; set; }

        public string ScanString { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }

    public class Codes_SRM_Dict : Dictionary<string, Codes_SRM>
    {
        public Codes_SRM_Dict(string plant)
        {
            DataTable HeadSRMCodes = DataHelper.ExecuteProc("Abattoir.Codes_SRM_Select", new ProcParams("plant", plant), DataBaseMaster.PlantConnectionString);

            foreach (DataRow dr in HeadSRMCodes.Rows)
            {
                Codes_SRM _item = new Codes_SRM()
                {
                    Code = dr.Field<byte>("Code"),
                    Description = dr.Field<string>("Description"),
                    ScanString = dr.Field<string>("ScanString")
                };

                Add(_item.ScanString, _item);
            }
        }
    }

}
