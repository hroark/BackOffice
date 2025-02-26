using System.Collections.Generic;
using System.Data;
using AFG.DataCollection.Common;
using AFG.DataCollection.Core;

namespace BackOffice.Models.Codes
{
    public class Codes_CondemnProduct
    {
        public byte Code { get; set; }
        public string ScanString { get; set; }
        public string Description { get; set; }
        public DataTable CondemnList { get; set; }
       

        public override string ToString()
        {
            return Description;
        }

    }

    public class Codes_CondemnProduct_Dict : Dictionary<string, Codes_CondemnProduct>
    {
        public Codes_CondemnProduct_Dict(CondemnScreenType reasonType, string plant)
        {
            DataTable _table = null;

            switch (reasonType)
            {
                case CondemnScreenType.HeadTable:
                    _table = DataHelper.ExecuteProc("Abattoir.Codes_HeadProduct_Select", new ProcParams("plant", plant), DataBaseMaster.PlantConnectionString);
                    break;

                case CondemnScreenType.VisceraTable:
                    _table = DataHelper.ExecuteProc("Abattoir.Codes_VisceraProduct_Select",  DataBaseMaster.PlantConnectionString);
                    break;
            }

            foreach (DataRow _row in _table.Rows)
            {
                Codes_CondemnProduct Item = new Codes_CondemnProduct();

                Item.Code = _row.Field<byte>("Code");
                Item.ScanString = _row.Field<string>("ScanString");
                Item.Description = _row.Field<string>("Description");

                Add(Item.ScanString, Item);

            }
        }
    }


}
