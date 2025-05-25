using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Info.Models;
using Microsoft.EntityFrameworkCore;

namespace Info.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Auditorium> Auditoriums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = @"C:\Users\USER\source\repos\Info\Info\auditoriums.db"; 
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
