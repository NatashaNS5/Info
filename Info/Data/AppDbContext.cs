using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Info.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Info.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Auditorium> Auditoriums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=auditoriums.db");
        }
    }
}