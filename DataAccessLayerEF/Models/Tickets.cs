using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayerEF.Models
{
    [Table("tickets", Schema = "public")]
    public class Tickets : BaseModel
    {
        [Column("doc_num")]
        public string DocumentNumber { get; set; } = string.Empty;

        [Column("doc_date")]
        public DateTime DocumentDate { get; set; }

        [Column("offer_id")]
        public Guid? OfferId { get; set; }

        public Offers? Offers { get; set; }

        [Column("offer_state")]
        public OfferState OfferState { get; set; }
    }

    public enum OfferState
    {
        ReadyForSale,
        Purchased,
        Booked
    }
}
