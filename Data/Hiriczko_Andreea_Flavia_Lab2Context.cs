using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hiriczko_Andreea_Flavia_Lab2.Models;

namespace Hiriczko_Andreea_Flavia_Lab2.Data
{
    public class Hiriczko_Andreea_Flavia_Lab2Context : DbContext
    {
        public Hiriczko_Andreea_Flavia_Lab2Context (DbContextOptions<Hiriczko_Andreea_Flavia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Hiriczko_Andreea_Flavia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Hiriczko_Andreea_Flavia_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Hiriczko_Andreea_Flavia_Lab2.Models.Author> Author { get; set; }
    }
}
