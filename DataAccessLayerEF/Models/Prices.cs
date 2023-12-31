using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerEF.Models
{
    [Table("prices", Schema = "public")]
    public class Prices : BaseModel
    {
        [Column("price_level")]
        public PriceLevel PriceLevel { get; set; }

        [Column("amount")]
        public decimal PriceAmount { get; set; }
    }

    public enum PriceLevel
    {
        Adult, 
        Child, 
        VIP
    }
}
