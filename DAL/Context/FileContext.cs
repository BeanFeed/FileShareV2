using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public class FileContext : DbContext
{
    public FileContext() { }
    
    public FileContext(DbContextOptions<FileContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.UseSqlite($"Data Source={Path.Join(Directory.GetCurrentDirectory(),"Data", "fileshare.sqlite")}");
    }
}