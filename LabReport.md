# Lab Report — AutoRent (Вариант19)

## Описание
AutoRent — WinForms приложение для учёта проката автомобилей. Реализовано согласно ТЗ (вариант19) для выполнения лабораторных работ.

## Структура проекта
- `AutoRent.Data` — модели и `AutoRentContext` (EF Core).
- `AutoRent.Services` — сервисы: `RentalService`, `ImportService`, `ReportService`, `Logger`.
- `AutoRent.UI` — WinForms интерфейс (MainForm, Cars, Clients, Rentals, Reports).

## Как запустить
1. Требуется .NET8 SDK.
2. В каталоге решения выполните:

```
dotnet build
dotnet run --project AutoRent.UI/AutoRent.UI.csproj
```

Приложение использует SQLite (`autorent.db`) и создаёт БД при первом запуске.

## Демонстрация (план)
1. ЛР1 — демонстрация моделей и БД
 - Открыть `AutoRent.Data\AutoRentContext.cs` и показать модели `Car`, `Client`, `Rental`.
 - Запустить приложение и показать, что `autorent.db` создан (файловый менеджер).
 - Показать содержимое таблиц (Cars/Clients) через формы.
2. ЛР2 — CRUD и LINQ
 - Показать формы Cars/Clients: добавить запись, удалить, показать обновление.
 - Перейти в Rentals: создать аренду (выбрать авто/клиента), попытаться создать пересекающуюся аренду — показать защиту.
 - Использовать фильтр аренды по фамилии клиента и по датам.
3. ЛР3 — Word
 - Открыть Reports -> Generate Rental Agreement (ввести RentalId) и открыть полученный `.docx`.
4. ЛР4 — Excel
 - Reports -> Export All Data to Excel -> открыть `.xlsx` и показать таблицы.
 - Import: импорт клиентов/авто из подготовленного `.xlsx` (показать отчёт импортера: added/skipped/errors).
5. ЛР5 — HTML
 - Reports -> Export Rentals to HTML -> открыть в браузере и показать группировку по клиенту.
6. Заключение
 - Показать `README.md` с командами, `LabReport.md`.

## Список ключевых файлов (листинги)
- `AutoRent.Data\Models\Car.cs`
- `AutoRent.Data\Models\Client.cs`
- `AutoRent.Data\Models\Rental.cs`
- `AutoRent.Data\Models\AutoRentContext.cs`
- `AutoRent.Services\RentalService.cs`
- `AutoRent.Services\ImportService.cs`
- `AutoRent.Services\ReportService.cs`
- `AutoRent.UI\Forms\RentalsForm.cs`

## SQL Dump
Файл `AutoRent.Data/Migrations/InitCreate.sql` содержит SQL-дамп схемы и seed данных.

## Примечания
- Для простоты используется SQLite и EnsureCreated(). Если требуется миграции EF, выполните локально `dotnet ef migrations add InitCreate --project AutoRent.Data`.
