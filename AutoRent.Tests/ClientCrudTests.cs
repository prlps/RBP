using System.Threading.Tasks;
using AutoRent.Data;
using AutoRent.Data.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace AutoRent.Tests
{
 public class ClientCrudTests
 {
 private AutoRentContext CreateInMemoryContext()
 {
 var options = new DbContextOptionsBuilder<AutoRentContext>()
 .UseInMemoryDatabase(System.Guid.NewGuid().ToString())
 .Options;
 return new AutoRentContext(options);
 }

 [Fact]
 public async Task AddClient_SavesToContext()
 {
 var ctx = CreateInMemoryContext();
 var cl = new Client { FirstName = "Test", LastName = "User", Address = "Addr" };
 ctx.Clients.Add(cl);
 await ctx.SaveChangesAsync();
 var saved = await ctx.Clients.FirstOrDefaultAsync(c => c.FirstName == "Test");
 Assert.NotNull(saved);
 }
 }
}
