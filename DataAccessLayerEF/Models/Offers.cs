using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayerEF.Models
{
    [Table("offers", Schema = "public")]
    public class Offers : BaseModel
    {
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("seat_id")]
        public Guid? SeatId { get; set; }

        [Column("price_id")]
        public Guid? PriceId { get; set; }

        [Column("event_id")]
        public Guid? EventId { get; set; }

        public Seats? Seats { get; set; }

        public Prices? Prices { get; set; }

        public Events? Events { get; set; }
    }
}
