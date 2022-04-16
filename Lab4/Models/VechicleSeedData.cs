using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Lab4.Data;

namespace Lab4.Models
{
    public static class VechicleSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Lab4Context(
            serviceProvider.GetRequiredService<
            DbContextOptions<Lab4Context>>()))
            {
                // Look for any movies.
                if (context.VechicleModel.Any())
                {
                    return; // DB has been seeded
                }
                context.VechicleModel.AddRange(
                new VechicleModel
                {
                    Company = "Toyota",
                    ModelType = "Corolla",
                    ReleaseDate = 2007,
                    RegistrationNumber = "у860рн",
                    RegistrationCity = 99,
                    Distance = 12000,
                    WasRepaired = false
                },
                new VechicleModel
                {
                    Company = "ВАЗ",
                    ModelType = "2110",
                    ReleaseDate = 2010,
                    RegistrationNumber = "ы567ав",
                    RegistrationCity = 77,
                    Distance = 49334,
                    WasRepaired = true
                },
                new VechicleModel
                {
                    Company = "Nissan",
                    ModelType = "Almera",
                    ReleaseDate = 2015,
                    RegistrationNumber = "ф436ва",
                    RegistrationCity = 77,
                    Distance = 12000,
                    WasRepaired = false
                },
                new VechicleModel
                {
                    Company = "Honda",
                    ModelType = "Civic",
                    ReleaseDate = 2013,
                    RegistrationNumber = "в687ап",
                    RegistrationCity = 55,
                    Distance = 15463,
                    WasRepaired = true
                }
                );
                context.SaveChanges();
            }
        }
    }
}