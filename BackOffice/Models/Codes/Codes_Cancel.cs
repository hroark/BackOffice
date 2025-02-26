using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AFG.DataCollection.Common;
using AFG.DataCollection.Core;

namespace BackOffice.Models.Codes
{
    public class Codes_Cancel
    {
        public Codes_Cancel(byte code, string description)
        {
            Code = code;
            Description = description;
        }
        public byte Code { get; set; }
        public string Description { get; set; }
    }
    public class Codes_Cancel_Dict : Dictionary<byte, Codes_Cancel>
    {
        public Codes_Cancel_Dict()
            : this(DataBaseMaster.AbattoirLocalExpressDb())
        {

        }
        public Codes_Cancel_Dict(string ConnectionString)
        {

            DataTable _cancelCodes = DataHelper.ExecuteProc("Abattoir.Codes_Cancel_Select", null, ConnectionString);


            foreach (DataRow _row in _cancelCodes.Rows)
            {
                Codes_Cancel _item = new Codes_Cancel(_row.Field<byte>("Code"), _row.Field<string>("Description"));
                
                Add(_item.Code, _item);
            }
        }
    }
}
