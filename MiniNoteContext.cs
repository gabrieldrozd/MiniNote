using Microsoft.EntityFrameworkCore;
using MiniNote.Database.Models;
using System;
using System.IO;

namespace MiniNote.Database
{
    public class MiniNoteContext : DbContext
    {
        public DbSet<Note> Note { get; set; }
        public DbSet<WorkTask> WorkTask { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserLoginDetail> UserLoginDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlite($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MiniNoteDB_TEST.sqlite")}");

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MiniNoteDB_TEST.sqlite")}");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(e => e.UserLoginDetail)
                .WithOne(e => e.User)
                .HasForeignKey<User>(e => e.UserName);

            //modelBuilder.Entity<City>()
            //.HasOne(e => e.CityInformation)
            //.WithOne(e => e.City)
            //.HasForeignKey<City>(e => e.CityInformationId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
