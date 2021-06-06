using System.Collections.Generic;
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

        // f
        // Users notes and work_tasks
        public List<Note> Note { get; set; }
        public List<WorkTask> WorkTask { get; set; }

        // user login_details
        public string UserName { get; set; }
        //public int UserLoginId { get; set; }
        public virtual UserLoginDetail UserLoginDetail { get; set; }
    }
}
