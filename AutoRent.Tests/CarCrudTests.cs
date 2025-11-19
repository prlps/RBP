using System.Threading.Tasks;
using AutoRent.Data;
using AutoRent.Data.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace AutoRent.Tests
{
 public class CarCrudTests
 {
 private AutoRentContext CreateInMemoryContext()
 {
 var options = new DbContextOptionsBuilder<AutoRentContext>()
 .UseInMemoryDatabase(System.Guid.NewGuid().ToString())
 .Options;
 return new AutoRentContext(options);
 }

 [Fact]
 public async Task AddCar_SavesToContext()
 {
 var ctx = CreateInMemoryContext();
 var car = new Car { Make = "Test", Type = "Sedan", RentalPricePerDay =10m };
 ctx.Cars.Add(car);
 await ctx.SaveChangesAsync();
 var saved = await ctx.Cars.FirstOrDefaultAsync(c => c.Make == "Test");
 Assert.NotNull(saved);
 }
 }
}
