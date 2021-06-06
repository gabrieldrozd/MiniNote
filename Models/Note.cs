using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniNote.Database.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        public string NoteName { get; set; }
        public string NoteContent { get; set; }
        public string NoteDescription { get; set; }
        // data systemowa pobierana w momencie dodania
        public DateTime NoteCreationDate { get; set; }


        // f
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
