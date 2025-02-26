namespace BackOffice.Models.Codes
{
    public class Codes_RunCodesAtGrading
    {
        public string ScanString { get; set; }

        public int RunCode { get; set; }
        public string RunCode_Description { get; set; }

        public int Grade { get; set; }
        public string Grade_Description { get; set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}", RunCode, Grade);
        }


        public static implicit operator Codes_Run(Codes_RunCodesAtGrading d)
        {
            return new Codes_Run(d.RunCode, d.RunCode_Description);
        }
        public static implicit operator Codes_Grade(Codes_RunCodesAtGrading d)
        {
            return new Codes_Grade(d.Grade, d.Grade_Description, d.ScanString);
        }



    }
    //public class Scan_TransformCodes_RunCodesAtGradingToRunCode : AFGObservableAFGObserver<Codes_RunCodesAtGrading, Codes_Run>
    //{
    //    protected override Codes_Run Receive(Codes_RunCodesAtGrading Item)
    //    {
    //        return Item;
    //    }
    //}
    //public class Scan_TransformCodes_RunCodesAtGradingToGrade : AFGObservableAFGObserver<Codes_RunCodesAtGrading, Codes_Grade> 
    //{
    //    protected override Codes_Grade Receive(Codes_RunCodesAtGrading Item)
    //    {
    //        return Item;
    //    }
    //}


    //public class Codes_RunCodesAtGrading_Dict : Dictionary<string, Codes_RunCodesAtGrading>
    //{
    //    public Codes_RunCodesAtGrading_Dict()
    //    {
    //        DataTable _table = DataHelper.ExecuteProc("Abattoir.RunCodesAtGrading_All_Active");

    //        foreach (DataRow _row in _table.Rows)
    //        {
    //            Codes_RunCodesAtGrading _item = new Codes_RunCodesAtGrading
    //            {
    //                ScanString = _row.Field<string>("ScanString"),
    //                RunCode = _row.Field<byte>("RunCode"),
    //                RunCode_Description = _row.Field<string>("RunCodeDescription"),
    //                Grade = _row.Field<byte>("Grade"),
    //                Grade_Description = _row.Field<string>("GradeDescription")
    //            };

    //            Add(_item.ScanString, _item);

    //        }


    //    }



    /// }
}
