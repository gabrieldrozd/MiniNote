using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniNote.Database.Models
{
    public class WorkTask
    {
        [Key]
        public int WorkTaskId { get; set; }
        public string WorkTaskName { get; set; }
        public string WorkTaskContent { get; set; }
        public string WorkTaskDescription { get; set; }
        // data systemowa pobierana w momencie dodania
        public DateTime WorkTaskCreationDate { get; set; }
        // data systemowa ustalona przez uzytkownika
        public DateTime WorkTaskDateOfExecution { get; set; }


        // f
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
