using HumansData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansData.Data
{
    public class HumanContext: DbContext
    {
        public DbSet<Human> Humans { get; set; }

        public HumanContext()
        {
      
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string msConn = "Server=(localdb)\\mssqllocaldb;Database=API.Data;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(msConn);

        }
    }
}
