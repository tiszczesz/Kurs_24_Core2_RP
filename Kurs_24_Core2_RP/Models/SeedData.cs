using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Kurs_24_Core2_RP.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Kurs_24_Core2_RPContext(
                serviceProvider
                    .GetRequiredService<DbContextOptions<Kurs_24_Core2_RPContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "ABC filmowania nocą",
                        ReleaseDate = DateTime.Parse("1999-12-24"),
                        Genre = "Obyczajowy",
                        Price = 12.99M
                    },
                    new Movie
                    {
                        Title = "Rybacy na Wakacjach",
                        ReleaseDate = DateTime.Parse("1978-4-12"),
                        Genre = "Komedia",
                        Price = 23.99M
                    },
                    new Movie
                    {
                        Title = "Tomcio Paluch",
                        ReleaseDate = DateTime.Parse("2005-8-21"),
                        Genre = "Obyczajowy",
                        Price = 34.69M
                    },
                    new Movie
                    {
                        Title = "Robaki nie płaczą",
                        ReleaseDate = DateTime.Parse("2001-3-12"),
                        Genre = "Komedia",
                        Price = 16.19M
                    },
                    new Movie
                    {
                        Title = "Franek w okopie",
                        ReleaseDate = DateTime.Parse("1967-11-11"),
                        Genre = "Wojenny",
                        Price = 56.69M
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
