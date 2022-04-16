using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Lab4.Data;

namespace Lab4.Models
{
    public static class MovieSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Lab4Context(
            serviceProvider.GetRequiredService<
            DbContextOptions<Lab4Context>>()))
            {
                // Look for any movies.
                if (context.MovieModel.Any())
                {
                    return; // DB has been seeded
                }
                context.MovieModel.AddRange(
                new MovieModel
                {
                    Title = "Когда Гарри встретил Салли",
                    ReleaseDate = DateTime.Parse("1989-7-21"),
                    Duration = 95,
                    Genre = "Романтическая комедия",
                    Price = 299
                },
                new MovieModel
                {
                    Title = "Охотники за привидениями",
                    ReleaseDate = DateTime.Parse("1984-6-7"),
                    Duration = 105,
                    Genre = "Комедия",
                    Price = 399
                },
                new MovieModel
                {
                    Title = "Охотники за привидениями 2",
                    ReleaseDate = DateTime.Parse("1989-6-12"),
                    Duration = 104,
                    Genre = "Комедия",
                    Price = 399
                },
                new MovieModel
                {
                    Title = "Рио браво",
                    ReleaseDate = DateTime.Parse("1959-3-18"),
                    Duration = 141,
                    Genre = "Вестерн",
                    Price = 199
                }
                );
                context.SaveChanges();
            }
        }
    }
}

