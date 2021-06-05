using System.ComponentModel.DataAnnotations;

namespace MiniNote.Database.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual 
    }
}
