using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniNote.Database.Models
{
    class WorkTask
    {
        [Key]
        public int WorkTaskId { get; set; }
        public string WorkTaskName { get; set; }
        public string WorkTaskContent { get; set; }
        public string WorkTaskDescription { get; set; }
        public DateTime WorkTaskCreationDate { get; set; }
    }
}
