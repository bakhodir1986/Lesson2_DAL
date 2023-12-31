using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayerEF.Models
{
    [Table("events", Schema = "public")]
    public class Events : BaseModel
    {
        [Required]
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("description")]
        public string? Description { get; set; }

        [Required]
        [Column("venue_id")]
        public Guid? VenueId { get; set; }

        [Required]
        [Column("event_datetime")]
        public DateTime EventTime { get; set; }

        public Venues? Venues { get; set; }
    }
}
