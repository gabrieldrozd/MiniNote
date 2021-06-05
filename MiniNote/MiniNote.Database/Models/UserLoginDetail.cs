using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniNote.Database.Models
{
    public class UserLoginDetail
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }


        // f
        // user connected to login_details
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
