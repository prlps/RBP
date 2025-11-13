# AutoRent

Простой WinForms проект для лабораторных работ «Прокат автомобилей» (вариант19).

Как запустить:

1. Убедитесь, что установлен .NET8 SDK.
2. В корне решения выполните:

 dotnet build

3. Проект использует SQLite (`autorent.db`) по умолчанию. При первом запуске база инициализируется и создаются seed-данные.

4. Запуск из командной строки (папка AutoRent.UI):

 dotnet run --project AutoRent.UI/AutoRent.UI.csproj

5. Для применения миграций (если хотите пересоздать БД):

 dotnet tool install --global dotnet-ef
 dotnet ef migrations add InitCreate --project AutoRent.Data
 dotnet ef database update --project AutoRent.Data

Файлы:
- `AutoRent.Data` — модели и EF Core DbContext.
- `AutoRent.Services` — бизнес-логика (RentalService) и вспомогательные утилиты.
- `AutoRent.UI` — WinForms интерфейс (MainForm, Cars/Clients/Rentals формы).

Примечание: проект создан упрощённо для лабораторных. Для реального использования следует добавить обработку ошибок, логирование и валидацию ввода.