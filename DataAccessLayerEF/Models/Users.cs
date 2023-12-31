using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayerEF.Models
{
    public class Users : BaseModel
    {
        [Column("user_name")]
        public string UserName { get; set; }

        [Column("user_type")]
        public UserType UserType { get; set; }
    }

    public enum UserType
    {
        Customer,
        EventManager
    }
}
