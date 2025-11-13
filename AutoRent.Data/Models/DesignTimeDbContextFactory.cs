using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AutoRent.Data
{
    // Эта фабрика используется инструментом миграций для создания DbContext
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AutoRentContext>
    {
        public AutoRentContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AutoRentContext>();

            // Для разработки используем SQLite — файл рядом с запускаемым проектом
            var dbPath = "AutoRent.db"; // можно указать абсолютный путь при необходимости
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

            return new AutoRentContext(optionsBuilder.Options);
        }
    }
}
