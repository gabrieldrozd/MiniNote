using Microsoft.EntityFrameworkCore;
using MiniNote.Database.Models;
using System;
using System.IO;

namespace MiniNote.Database
{
    public class MiniNoteContext : DbContext
    {
        public DbSet<Note> NotesClass { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MiniNoteDB.sqlite")}");
        }
    }
}
