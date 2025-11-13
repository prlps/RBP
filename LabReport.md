# Lab Report — AutoRent (Вариант19)

## Краткое описание
AutoRent — WinForms приложение для учёта проката автомобилей.
Реализовано: модели (Car, Client, Rental), EF Core DbContext, CRUD-интерфейс (WinForms), импорт/экспорт, генерация Word/HTML, проверки доступности авто, транзакции и логирование.

## Сборка и запуск (локально)
Требования: .NET8 SDK.

1. В корне репозитория выполните:

```
dotnet build
dotnet run --project AutoRent.UI/AutoRent.UI.csproj
```

2. При первом запуске приложение создаст файл БД `autorent.db` (в папке с исполняемым файлом) и заполнит seed-данными.
 - Если хотите применить миграции EF вместо EnsureCreated:

```
# установить dotnet-ef если нужно:
# dotnet tool install --global dotnet-ef

dotnet ef database update --project AutoRent.Data --startup-project AutoRent.UI
```

## Структура проекта (важные файлы)
- `AutoRent.Data` — модели и `AutoRentContext` (EF Core)
 - `Models\Car.cs`, `Client.cs`, `Rental.cs`
 - `Models\AutoRentContext.cs`
 - `Migrations\` — миграция `InitCreate` + SQL dump `InitCreate.sql`
- `AutoRent.Services` — бизнес-логика
 - `RentalService.cs` — проверка доступности, создание/закрытие аренды
 - `ImportService.cs`, `ReportService.cs`, `Logger.cs`
- `AutoRent.UI` — WinForms
 - `Forms\CarsForm`, `ClientsForm`, `RentalsForm`, `ReportsForm`
 - `Program.cs` — startup (SQLite, seeding)

## План демонстрации по лабораторным работам
Ниже приведён пошаговый сценарий, который можно демонстрировать преподавателю. Для каждого шага указано ожидаемое поведение.

### ЛР1 — структуры данных и БД
1. Открыть `AutoRent.Data\Models` и показать классы `Car`, `Client`, `Rental`.
2. Показать `AutoRent.Data\Models\AutoRentContext.cs` — конфигурации моделей и seed-данные.
3. Запустить приложение (см. раздел "Сборка и запуск").
4. Проверить наличие файла `autorent.db` и/или выполнить SQLite viewer, показать таблицы.

Ожидаемо: при первом старте DB создаётся, seed-данные добавляются.

Скриншот: `screenshots/lr1_db_created.png` (покажите файл и содержимое таблиц в DB-браузере).

### ЛР2 — UI и CRUD, LINQ-фильтры
1. Открыть форму `Cars`:
 - Добавить новую запись (Make, Type, цены).
 - Удалить запись.
 - Продемонстрировать фильтрацию по Make и Type (верхние поля).
2. Открыть форму `Clients`:
 - Добавить клиента (LastName/FirstName обязательны), удалить клиента.
3. Открыть форму `Rentals`:
 - Создать аренду: выбрать автомобиль и клиента, указать дату выдачи и планируемую дату возврата. Цена подставляется автоматически.
 - Попробовать создать пересекающуюся аренду для того же авто — система должна отказать (проверка доступности).
 - Закрыть аренду: выбрать строку и указать фактическую дату возврата — итоговая сумма считается автоматически.
 - Использовать фильтры: по фамилии клиента и по диапазону дат, показать, что фильтрация работает.

Ожидаемо: CRUD работоспособен, валидация полей, фильтрация обновляет список.

Скриншоты:
- `screenshots/lr2_cars_crud.png` (добавление автомобиля)
- `screenshots/lr2_rentals_create.png` (создание аренды)
- `screenshots/lr2_rentals_filter.png` (фильтрация по фамилии)

### ЛР3 — Word (договор)
1. Открыть `Reports` -> `Generate Rental Agreement`.
2. Ввести `RentalId` (например,1), сохранить `.docx` и открыть его в Word.

Ожидаемо: создан файл `.docx` с базовыми данными аренды (клиент, авто, даты, цена и примечания).

Скриншот: `screenshots/lr3_agreement_docx.png`.

### ЛР4 — Excel (экспорт/импорт)
1. В `Reports` нажать `Export All Data to Excel`, сохранить файл.
 - Открыть файл `.xlsx` и показать листы `Cars`, `Clients`, `Rentals`.
2. Подготовить XLSX (или взять шаблон) и нажать `Import Clients from Excel` / `Import Cars from Excel`.
 - Важно: формат столбцов описан в подсказках (ToolTip) в форме.
 - После импорта показать сообщение с результатами (Added/Skipped/Errors) и обновлённый UI.

Ожидаемо: экспорт создаёт валидный `.xlsx`, импорт добавляет новые записи, пропускает дубликаты.

Скриншоты:
- `screenshots/lr4_export_excel.png`
- `screenshots/lr4_import_result.png`

### ЛР5 — HTML отчет
1. Reports -> Export Rentals to HTML -> открыть файл в браузере.
2. Продемонстрировать, что отчёт сгруппирован по клиенту и содержит таблицы аренды.

Скриншот: `screenshots/lr5_html_report.png`.

## Тест-кейсы (ручные)
1. Проверка создания аренды:
 - Входные данные: существующий автомобиль и клиент, DateOut = today, PlannedReturn = today+2
 - Ожидаемо: аренда создана, car.IsAvailable = false
2. Пересечение аренды:
 - Создать аренду на период, затем попытаться создать новую на пересекающийся период — ожидать отказ
3. Закрытие аренды:
 - Закрыть аренду с фактической датой > DateOut — рассчитать TotalPrice правильно (минимум1 день)
4. Импорт с ошибками:
 - Подать файл с некорректным числовым значением в поле `RentalPricePerDay` — ожидать сообщение о строке с ошибкой и пропуск

## Отладочные и проверочные команды
- Сборка: `dotnet build`
- Запуск: `dotnet run --project AutoRent.UI/AutoRent.UI.csproj`
- Создание/применение миграций (опционально):
 - `dotnet tool install --global dotnet-ef`
 - `dotnet ef migrations add InitCreate --project AutoRent.Data --startup-project AutoRent.UI`
 - `dotnet ef database update --project AutoRent.Data --startup-project AutoRent.UI`
- SQL-дамп (в репозитории): `AutoRent.Data/Migrations/InitCreate.sql` — содержит DDL + INSERT seed.

## Места, где смотреть код (коротко)
- Логика аренды: `AutoRent.Services/RentalService.cs`
- Импорт/экспорт: `AutoRent.Services/ImportService.cs`, `AutoRent.Services/ReportService.cs`
- UI: `AutoRent.UI/Forms/*`
- Контекст EF: `AutoRent.Data/Models/AutoRentContext.cs`

## Рекомендации преподавателю (демонстрация)
- Запустите приложение и последовательно выполняйте пункты из плана демонстрации. Показать, что все операции записываются в лог `logs/app.log` (при наличии прав на запись).
- Попросите студента продемонстрировать добавление записи, создание и закрытие аренды, экспорт и импорт.

## Папка со скриншотами
В репозитории создайте папку `screenshots/` и поместите туда файлы по названиям, указанным выше. Для отчёта приложите5–8 скриншотов основных шагов.

---

Дата подготовки отчёта:2025-11-13
