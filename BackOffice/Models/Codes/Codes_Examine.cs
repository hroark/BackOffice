using System.Data;
using System.Linq;
using System.Text;
using AFG.DataCollection.Common;

namespace BackOffice.Models.Codes
{
    public class Codes_Examine
    {
        [Key]
        public byte Code { get; set; }
        public required string Description { get; set; }
        public required string ScanString { get; set; }
        public bool Pass { get; set; } 

        public override string ToString()
        {
            return Description;
        }
    }




}
