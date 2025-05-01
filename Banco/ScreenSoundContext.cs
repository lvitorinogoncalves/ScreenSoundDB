using Microsoft.EntityFrameworkCore;
using ScreenSoundDB.Modelos;

namespace ScreenSoundDB.Banco;

public class ScreenSoundContext: DbContext
{
    public DbSet<Artista> Artistas { get; set; }
    public DbSet<Musica> Musicas { get; set; }
    private readonly string connectionString = "Data Source=localhost,1401; Initial Catalog=screenSoundNew; User ID=sa; Password=Jesus*10; Encrypt=False;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
    }
}
