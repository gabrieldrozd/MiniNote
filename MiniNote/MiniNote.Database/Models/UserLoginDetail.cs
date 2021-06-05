using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniNote.Database.Models
{
    class UserLoginDetails
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
