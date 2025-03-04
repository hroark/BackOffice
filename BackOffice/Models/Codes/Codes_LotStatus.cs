using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AFG.DataCollection.Common;
using AFG.DataCollection.Core;

namespace BackOffice.Models.Codes
{
    public class Codes_LotStatus
    {
        public Codes_LotStatus(byte status,string description)
        {
            Code = status;
            Description = description;
        }

        public Codes_LotStatus()
        {
            
        }
        public string Description { get; set; }

        public byte Code { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }

    public class Codes_LotStatus_Dict : Dictionary<byte, Codes_LotStatus>
    {
        public Codes_LotStatus_Dict()
            : this(DataBaseMaster.AbattoirLocalExpressDb())
        {

        }
        public Codes_LotStatus_Dict(string ConnectionString)
        {

            DataTable _statusCodes = DataHelper.ExecuteProc("Abattoir.Codes_LotStatus_Select", null, ConnectionString);


            foreach (DataRow _row in _statusCodes.Rows)
            {
                Codes_LotStatus _item = new Codes_LotStatus()
                {
                    Code = _row.Field<byte>("Code"),
                    Description = _row.Field<string>("Description")
                    
                };

                Add(_item.Code, _item);

            }
        }
    }
}
