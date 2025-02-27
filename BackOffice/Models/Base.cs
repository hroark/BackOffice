using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BackOffice.Models
{
    [PrimaryKey("EventDate", "PlantCode")]
    public class Base
    {
        public required DateTime EventDate { get; set; }
        public required string PlantCode { get; set; }
        public required DateTime HarvestDate { get; set; }
       // public long ScanId { get; set; }
        public int StationType { get; set; }
        public required string StationName { get; set; }
    }
}
