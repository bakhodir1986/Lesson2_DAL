using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerEF.Models
{
    public class BaseModel
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; } = DateTime.Now;

        [Column("create_user")]
        public Guid? CreateUser { get; set; }

        [Column("update_date")]
        public DateTime UpdateDate { get; set; } = DateTime.Now;

        [Column("update_user")]
        public Guid? UpdateUser { get; set; }
    }
}
