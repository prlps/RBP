using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using AutoRent.Data;

#nullable disable

namespace AutoRent.Data.Migrations
{
 [DbContext(typeof(AutoRentContext))]
 partial class AutoRentContextModelSnapshot : ModelSnapshot
 {
 protected override void BuildModel(ModelBuilder modelBuilder)
 {
 modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

 modelBuilder.Entity("AutoRent.Data.Models.Car", b =>
 {
 b.Property<int>("CarId").ValueGeneratedOnAdd().HasColumnType("INTEGER");
 b.Property<decimal>("PurchasePrice").HasColumnType("decimal(12,2)");
 b.Property<bool>("IsAvailable").HasColumnType("INTEGER");
 b.Property<string>("Make").IsRequired().HasMaxLength(100).HasColumnType("TEXT");
 b.Property<string>("Type").IsRequired().HasMaxLength(50).HasColumnType("TEXT");
 b.Property<decimal>("RentalPricePerDay").HasColumnType("decimal(10,2)");
 b.HasKey("CarId");
 b.ToTable("Cars");
 });

 modelBuilder.Entity("AutoRent.Data.Models.Client", b =>
 {
 b.Property<int>("ClientId").ValueGeneratedOnAdd().HasColumnType("INTEGER");
 b.Property<string>("Address").IsRequired().HasColumnType("TEXT");
 b.Property<string>("FirstName").IsRequired().HasMaxLength(100).HasColumnType("TEXT");
 b.Property<string>("LastName").IsRequired().HasMaxLength(100).HasColumnType("TEXT");
 b.Property<string>("MiddleName").HasColumnType("TEXT");
 b.Property<string>("Phone").HasMaxLength(50).HasColumnType("TEXT");
 b.HasKey("ClientId");
 b.ToTable("Clients");
 });

 modelBuilder.Entity("AutoRent.Data.Models.Rental", b =>
 {
 b.Property<int>("RentalId").ValueGeneratedOnAdd().HasColumnType("INTEGER");
 b.Property<int>("CarId").HasColumnType("INTEGER");
 b.Property<int>("ClientId").HasColumnType("INTEGER");
 b.Property<DateTime>("DateOut").HasColumnType("TEXT");
 b.Property<DateTime>("PlannedReturnDate").HasColumnType("TEXT");
 b.Property<DateTime?>("ActualReturnDate").HasColumnType("TEXT");
 b.Property<decimal>("PricePerDay").HasColumnType("decimal(10,2)");
 b.Property<decimal?>("TotalPrice").HasColumnType("decimal(12,2)");
 b.Property<string>("Notes").HasColumnType("TEXT");
 b.HasKey("RentalId");
 b.HasIndex("CarId");
 b.HasIndex("ClientId");
 b.ToTable("Rentals");
 });

 modelBuilder.Entity("AutoRent.Data.Models.Rental", b =>
 {
 b.HasOne("AutoRent.Data.Models.Car").WithMany().HasForeignKey("CarId").OnDelete(DeleteBehavior.Cascade);
 b.HasOne("AutoRent.Data.Models.Client").WithMany().HasForeignKey("ClientId").OnDelete(DeleteBehavior.Cascade);
 });
 }
 }
}
