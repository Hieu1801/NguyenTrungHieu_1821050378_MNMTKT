#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MaNguonMo.Models;
namespace MaNguonMo.Data{
     public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MaNguonMo.Models.Movie> Movie { get; set; }

        public DbSet<MaNguonMo.Models.Student> Student { get; set; }

        public DbSet<MaNguonMo.Models.Employee> Employee { get; set; }

        public DbSet<MaNguonMo.Models.Person> Person { get; set; }

        public DbSet<MaNguonMo.Models.Customer> Customer { get; set; }
    }
}
   
