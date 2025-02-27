using System.ComponentModel.DataAnnotations;

namespace BackOffice.Models
{
    public class Base
    {
        [Key]
        public required DateTime EventDate { get; set; }
        [Key]
        public required string PlantCode { get; set; }
        public required DateTime HarvestDate { get; set; }
       // public long ScanId { get; set; }
        public int StationType { get; set; }
        public required string StationName { get; set; }

              
        
    }
}
