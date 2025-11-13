using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoRent.Data;
using AutoRent.Data.Models;

namespace AutoRent.Services
{
 public class RentalService
 {
 private readonly AutoRentContext _context;

 public RentalService(AutoRentContext context)
 {
 _context = context ?? throw new ArgumentNullException(nameof(context));
 }

 // ѕровер€ет доступность автомобил€ на указанный период (включительно)
 public async Task<bool> IsCarAvailableAsync(int carId, DateTime dateOut, DateTime plannedReturnDate)
 {
 if (plannedReturnDate < dateOut) throw new ArgumentException("Planned return date must be after date out");

 return !await _context.Rentals
 .AsNoTracking()
 .Where(r => r.CarId == carId)
 .AnyAsync(r =>
 // существующа€ аренда перекрываетс€ с новым периодом
 (r.ActualReturnDate == null ? r.PlannedReturnDate : r.ActualReturnDate) >= dateOut &&
 r.DateOut <= plannedReturnDate
 );
 }

 // —оздаЄт новую аренду если авто доступно. ¬озвращает созданную сущность или null если не удалось.
 public async Task<Rental?> CreateRentalAsync(int carId, int clientId, DateTime dateOut, DateTime plannedReturnDate, decimal pricePerDay, string? notes = null)
 {
 if (plannedReturnDate < dateOut) throw new ArgumentException("Planned return date must be after date out");

 using var tx = await _context.Database.BeginTransactionAsync();
 try
 {
 // Reload car to ensure up-to-date
 var car = await _context.Cars.FindAsync(carId);
 if (car == null) throw new InvalidOperationException("Car not found");

 if (!await IsCarAvailableAsync(carId, dateOut, plannedReturnDate))
 return null;

 var rental = new Rental
 {
 CarId = carId,
 ClientId = clientId,
 DateOut = dateOut,
 PlannedReturnDate = plannedReturnDate,
 PricePerDay = pricePerDay,
 Notes = notes
 };

 _context.Rentals.Add(rental);
 // mark car unavailable while rented
 car.IsAvailable = false;
 _context.Cars.Update(car);

 await _context.SaveChangesAsync();
 await tx.CommitAsync();

 Logger.Info($"Created rental {rental.RentalId} car:{carId} client:{clientId} {dateOut:d} - {plannedReturnDate:d}");
 return rental;
 }
 catch (Exception ex)
 {
 try { await tx.RollbackAsync(); } catch { }
 Logger.Error("CreateRentalAsync error: " + ex);
 throw;
 }
 }

 // «акрытие аренды: устанавливает фактическую дату и рассчитывает итоговую сумму
 public async Task<Rental?> CloseRentalAsync(int rentalId, DateTime actualReturnDate)
 {
 using var tx = await _context.Database.BeginTransactionAsync();
 try
 {
 var rental = await _context.Rentals.Include(r => r.Car).FirstOrDefaultAsync(r => r.RentalId == rentalId);
 if (rental == null) return null;
 if (actualReturnDate < rental.DateOut) throw new ArgumentException("Actual return date cannot be earlier than DateOut");

 rental.ActualReturnDate = actualReturnDate;
 var days = (int)Math.Ceiling((actualReturnDate.Date - rental.DateOut.Date).TotalDays);
 if (days <1) days =1; // минимум один день
 rental.TotalPrice = rental.PricePerDay * days;

 // mark car available if no other active rentals overlapping
 var car = rental.Car;
 if (car != null)
 {
 var hasOtherActive = await _context.Rentals
 .AsNoTracking()
 .Where(r => r.CarId == car.CarId && r.RentalId != rental.RentalId)
 .AnyAsync(r => (r.ActualReturnDate == null || r.ActualReturnDate >= actualReturnDate));
 if (!hasOtherActive)
 {
 car.IsAvailable = true;
 _context.Cars.Update(car);
 }
 }

 await _context.SaveChangesAsync();
 await tx.CommitAsync();

 Logger.Info($"Closed rental {rental.RentalId} actualReturn:{actualReturnDate:d} total:{rental.TotalPrice}");
 return rental;
 }
 catch (Exception ex)
 {
 try { await tx.RollbackAsync(); } catch { }
 Logger.Error("CloseRentalAsync error: " + ex);
 throw;
 }
 }
 }
}
