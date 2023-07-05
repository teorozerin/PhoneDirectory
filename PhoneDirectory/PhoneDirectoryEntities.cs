using Microsoft.EntityFrameworkCore;
using PhoneDirectory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory
{
    public class PhoneDirectoryEntities : DbContext
    {
        public DbSet <User> user { get; set; }
        public DbSet<Person> person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-F23C5M8;Initial Catalog=PhoneDirectory;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
