-- SQL schema for AutoRent (InitCreate)
-- Compatible with SQLite
PRAGMA foreign_keys = ON;

CREATE TABLE IF NOT EXISTS "Cars" (
 "CarId" INTEGER PRIMARY KEY AUTOINCREMENT,
 "Make" TEXT NOT NULL,
 "Type" TEXT NOT NULL,
 "PurchasePrice" DECIMAL(12,2) DEFAULT0,
 "RentalPricePerDay" DECIMAL(10,2) DEFAULT0,
 "IsAvailable" BOOLEAN DEFAULT1
);

CREATE TABLE IF NOT EXISTS "Clients" (
 "ClientId" INTEGER PRIMARY KEY AUTOINCREMENT,
 "LastName" TEXT NOT NULL,
 "FirstName" TEXT NOT NULL,
 "MiddleName" TEXT,
 "Address" TEXT NOT NULL,
 "Phone" TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS "Rentals" (
 "RentalId" INTEGER PRIMARY KEY AUTOINCREMENT,
 "CarId" INTEGER NOT NULL,
 "ClientId" INTEGER NOT NULL,
 "DateOut" TEXT NOT NULL,
 "PlannedReturnDate" TEXT NOT NULL,
 "ActualReturnDate" TEXT,
 "PricePerDay" DECIMAL(10,2) NOT NULL,
 "TotalPrice" DECIMAL(12,2),
 "Notes" TEXT,
 FOREIGN KEY ("CarId") REFERENCES "Cars" ("CarId") ON DELETE CASCADE,
 FOREIGN KEY ("ClientId") REFERENCES "Clients" ("ClientId") ON DELETE CASCADE
);

-- Seed data
INSERT INTO "Cars" ("Make","Type","PurchasePrice","RentalPricePerDay","IsAvailable") VALUES
('Toyota Corolla','Sedan',15000,50,1),
('Honda CR-V','SUV',25000,80,1),
('Ford Fiesta','Hatchback',12000,40,1);

INSERT INTO "Clients" ("LastName","FirstName","MiddleName","Address","Phone") VALUES
('Ivanov','Ivan',NULL,'Moscow','+79991234567'),
('Petrova','Anna',NULL,'Saint Petersburg','+79997654321');

INSERT INTO "Rentals" ("CarId","ClientId","DateOut","PlannedReturnDate","PricePerDay") VALUES
(1,1, date('now','-2 days'), date('now','+3 days'),50);

-- End of SQL dump
