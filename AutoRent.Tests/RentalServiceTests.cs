using System;
using System.Threading.Tasks;
using AutoRent.Data;
using AutoRent.Data.Models;
using AutoRent.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace AutoRent.Tests
{
 public class RentalServiceTests
 {
 private AutoRentContext CreateInMemoryContext()
 {
 var options = new DbContextOptionsBuilder<AutoRentContext>()
 .UseInMemoryDatabase(Guid.NewGuid().ToString())
 .Options;
 var ctx = new AutoRentContext(options);
 return ctx;
 }

 [Fact]
 public async Task CreateRental_MarksCarUnavailable_And_SavesRental()
 {
 var ctx = CreateInMemoryContext();
 ctx.Cars.Add(new Car { CarId =1, Make = "T", Type = "S", RentalPricePerDay =10m, IsAvailable = true });
 ctx.Clients.Add(new Client { ClientId =1, FirstName = "FN", LastName = "LN", Address = "A" });
 await ctx.SaveChangesAsync();

 var svc = new RentalService(ctx);
 var rental = await svc.CreateRentalAsync(1,1, DateTime.Today, DateTime.Today.AddDays(2),10m, "note");
 Assert.NotNull(rental);
 var car = await ctx.Cars.FindAsync(1);
 Assert.False(car.IsAvailable);
 }

 [Fact]
 public async Task CloseRental_CalculatesTotal_And_MarksAvailable()
 {
 var ctx = CreateInMemoryContext();
 var car = new Car { CarId =1, Make = "T", Type = "S", RentalPricePerDay =10m, IsAvailable = false };
 ctx.Cars.Add(car);
 var client = new Client { ClientId =1, FirstName = "FN", LastName = "LN", Address = "A" };
 ctx.Clients.Add(client);
 var rental = new Rental { RentalId =1, CarId =1, ClientId =1, DateOut = DateTime.Today.AddDays(-3), PlannedReturnDate = DateTime.Today.AddDays(1), PricePerDay =10m };
 ctx.Rentals.Add(rental);
 await ctx.SaveChangesAsync();

 var svc = new RentalService(ctx);
 var closed = await svc.CloseRentalAsync(1, DateTime.Today);
 Assert.NotNull(closed);
 Assert.True(closed.TotalPrice.HasValue);
 var updatedCar = await ctx.Cars.FindAsync(1);
 Assert.True(updatedCar.IsAvailable);
 }
 }
}
