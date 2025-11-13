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

 // ѕроверка на пересечение интервалов аренды: [DateOut, PlannedReturnDate]
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
 try
 {
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
 await _context.SaveChangesAsync();

 Logger.Info($"Created rental {rental.RentalId} car:{carId} client:{clientId} {dateOut:d} - {plannedReturnDate:d}");
 return rental;
 }
 catch (Exception ex)
 {
 Logger.Error("CreateRentalAsync error: " + ex);
 throw;
 }
 }

 // «акрытие аренды: устанавливает фактическую дату и рассчитывает итоговую сумму
 public async Task<Rental?> CloseRentalAsync(int rentalId, DateTime actualReturnDate)
 {
 try
 {
 var rental = await _context.Rentals.FindAsync(rentalId);
 if (rental == null) return null;

 rental.ActualReturnDate = actualReturnDate;

 var days = (int)Math.Ceiling((actualReturnDate.Date - rental.DateOut.Date).TotalDays);
 if (days <1) days =1; // минимум один день

 rental.TotalPrice = rental.PricePerDay * days;

 await _context.SaveChangesAsync();

 Logger.Info($"Closed rental {rental.RentalId} actualReturn:{actualReturnDate:d} total:{rental.TotalPrice}");
 return rental;
 }
 catch (Exception ex)
 {
 Logger.Error("CloseRentalAsync error: " + ex);
 throw;
 }
 }
 }
}
