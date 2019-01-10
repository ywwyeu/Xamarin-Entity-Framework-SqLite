using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace temp.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Item> Item { get; set; }
        private string DatabasePath { get; set; }

        public MyContext()
        {
            //Database.EnsureCreated();
            //Database.Migrate();

        }

        public MyContext(string databasePath)
        {
            DatabasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }
    }
}