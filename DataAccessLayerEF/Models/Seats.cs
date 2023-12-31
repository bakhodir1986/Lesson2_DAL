using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayerEF.Models
{
    [Table("seats", Schema = "public")]
    public class Seats : BaseModel
    {
        [Required]
        [Column("venue_id")]
        public Guid VenueId { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Column("row")]
        public string? Row { get; set; }

        [Required]
        [Column("section")]
        public string? Section { get; set; }

        [Required]
        [Column("seat_type")]
        public SeatTypeEnum SeatType { get; set; }
    }

    public enum SeatTypeEnum
    {
        Standart,
        GeneralAdmission
    }
}
