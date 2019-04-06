using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Kurs_24_Core2_RP.Models
{
    public class Kurs_24_Core2_RPContext : DbContext
    {
        public Kurs_24_Core2_RPContext (DbContextOptions<Kurs_24_Core2_RPContext> options)
            : base(options)
        {
        }

        public DbSet<Kurs_24_Core2_RP.Models.Movie> Movie { get; set; }
    }
}
