using System.Data;

namespace BackOffice.Models.Codes
{
    public class Codes_MudScore
    {
        public int Score { get; set; }
        public bool NotifyPlant { get; set; }
        public string Plant { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }

    //public class Codes_MudScore_Dict : Dictionary<int, Codes_MudScore>
    //{
    //    public Codes_MudScore_Dict(string plant)
    //    {
    //        // DGC20191025 - char plant
    //        //DataTable _mudScores = DataHelper.ExecuteProc("Abattoir.Codes_MudScores_Select", new ProcParams("Plant", plant), DataBaseMaster.AbattoirLocalExpressDb());

    //        //PRP20191218 - need to use this stored proc
    //        DataTable _mudScores = DataHelper.ExecuteProc("Abattoir.Codes_MudScores_Select_V2", new ProcParams("Plant", int.Parse(plant)), DataBaseMaster.AbattoirLocalExpressDb());

    //        foreach (DataRow _customHarvestRow in _mudScores.Rows)
    //        {
    //            Codes_MudScore _item = new Codes_MudScore()
    //            {
    //                Score = _customHarvestRow.Field<byte>("Score"),
    //                NotifyPlant = _customHarvestRow.Field<bool>("NotifyPlant"),
    //                Description = _customHarvestRow.Field<string>("Description"),
    //            };


    //            Add(_item.Score, _item);

    //        }
    //    }
    //}
}
