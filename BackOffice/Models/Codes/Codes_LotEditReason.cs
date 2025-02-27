using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BackOffice.Models.Codes
{
    public class Codes_LotEditReason
    {
        [Key]
        public byte ReasonKey { get; set; }
        [Key]
        public required string PlantCode { get; set; }
        public required string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }

    //public class Codes_LotEditReason_Dict : Dictionary<int, Codes_LotEditReason>
    //{
    //    public Codes_LotEditReason_Dict()
    //    {
    //        //string plant = GetPlant();
    //        //if (plant.Length == 1) plant = "0" + plant;
    //        DataTable _dt = DataHelper.ExecuteProc("Abattoir.Codes_LotEditReasons_Select_V2", new ProcParams("Plant", GetPlant()));

    //        foreach (DataRow _row in _dt.Rows)
    //        {
    //            Codes_LotEditReason _item = new Codes_LotEditReason
    //            {
    //                Key = _row.Field<byte>("ReasonKey"),
    //                Description = _row.Field<string>("Description")
    //            };


    //            Add(_item.Key, _item);
    //        }

    //    }

    //    public string GetPlant()
    //    {
    //        /*get _plant */
    //        if (MySettings.get_Item("Plant").Length != 0) return MySettings.get_Item("Plant");

    //        return string.Empty;
    //    }
    //}

}