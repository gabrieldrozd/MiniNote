﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniNote.Database.Models
{
    class Note
    {
        [Key]
        public int NoteId { get; set; }
        public string NoteName { get; set; }
        public string NoteContent { get; set; }
        public string NoteDescription { get; set; }
        public DateTime NoteCreationDate { get; set; }
    }
}
