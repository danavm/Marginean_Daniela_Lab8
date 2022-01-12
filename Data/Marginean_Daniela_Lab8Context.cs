using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marginean_Daniela_Lab8.Models;

namespace Marginean_Daniela_Lab8.Data
{
    public class Marginean_Daniela_Lab8Context : DbContext
    {
        public Marginean_Daniela_Lab8Context (DbContextOptions<Marginean_Daniela_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Marginean_Daniela_Lab8.Models.Book> Book { get; set; }

        public DbSet<Marginean_Daniela_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Marginean_Daniela_Lab8.Models.Category> Category { get; set; }
    }
}
