using AutoRent.Data.Models;
using System;
using System.Linq;

namespace AutoRent.Data
{
    public static class SeedData
    {
        public static void Initialize(AutoRentContext context)
        {
            // Do not call Migrate here; Program ensures database is created.

            if (!context.Cars.Any())
            {
                context.Cars.AddRange(
                    new Car { Make = "Toyota Corolla", Type = "Sedan", PurchasePrice = 15000, RentalPricePerDay = 50 },
                    new Car { Make = "Honda CR-V", Type = "SUV", PurchasePrice = 25000, RentalPricePerDay = 80 },
                    new Car { Make = "Ford Fiesta", Type = "Hatchback", PurchasePrice = 12000, RentalPricePerDay = 40 }
                );
            }

            if (!context.Clients.Any())
            {
                context.Clients.AddRange(
                    new Client { FirstName = "Ivan", LastName = "Ivanov", Address = "Moscow", Phone = "+79991234567" },
                    new Client { FirstName = "Anna", LastName = "Petrova", Address = "Saint Petersburg", Phone = "+79997654321" }
                );
            }

            if (!context.Rentals.Any())
            {
                context.Rentals.Add(new Rental
                {
                    CarId = 1,
                    ClientId = 1,
                    DateOut = DateTime.Today.AddDays(-2),
                    PlannedReturnDate = DateTime.Today.AddDays(3),
                    PricePerDay = 50
                });
            }

            context.SaveChanges();
        }
    }
}
