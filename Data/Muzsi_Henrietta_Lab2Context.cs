using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Muzsi_Henrietta_Lab2.Models;

namespace Muzsi_Henrietta_Lab2.Data
{
    public class Muzsi_Henrietta_Lab2Context : DbContext
    {
        public Muzsi_Henrietta_Lab2Context (DbContextOptions<Muzsi_Henrietta_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Muzsi_Henrietta_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Muzsi_Henrietta_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Muzsi_Henrietta_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Muzsi_Henrietta_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Muzsi_Henrietta_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Muzsi_Henrietta_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}
