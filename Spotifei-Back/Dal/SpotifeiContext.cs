using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata; //baixar bibliotecas Microsoft.EntityFrameworkCore.Design e Microsoft.EntityFrameworkCore

class SpotifeiContext : DbContext
{
    string connection = "Server=localhost;Port=3306;Database=Spotifei;Uid=root;Pwd=;"; //ajustar senha dependendo da maquina
    public DbSet<Playlist> Playlists {get; set; }
    public DbSet<Artista> Artistas {get; set;}
    public DbSet<Ouvinte> Ouvintes { get; set; }
    public DbSet<Musica> Musicas {get; set; }
    public DbSet<Album> Albuns { get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
    {
        optionsbuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Playlist>().ToTable("Playlists");
        builder.Entity<Artista>().ToTable("Artistas");
        builder.Entity<Ouvinte>().ToTable("Ouvintes");
        builder.Entity<Musica>().ToTable("Musicas");
        builder.Entity<Album>().ToTable("Albuns");
        builder.Entity<Usuario>().HasMany(u => u.Playlists).WithOne(p => p.Usuario).HasForeignKey(p => p.UsuarioId);
        builder.Entity<Playlist>().HasMany(p => p.Musicas).WithOne(m => m.Playlist).HasForeignKey(m => m.PlaylistId);
        builder.Entity<Artista>().HasData(
            new Artista()
            {
                Id = 1,
                NomeDoUsuario = "Carlos Alberto",
                Email = "CarlosAlbertoOficial@hootmail.com.br",
                Senha = "0123450",
                Status = 2
            }
        );
        builder.Entity<Playlist>().HasData(
            new Playlist()
            {
                Id = 1,
                Nome = "Musicas do Carlos",
                DataCriacao = DateTime.Now,
                NumeroMusicas = 1,
                UsuarioId = 1
            }
        );
        builder.Entity<Musica>().HasData(
            new Musica()
            {
                Id = 1,
                Descricao = "Musica do Carlos",
                DataPublicacao = DateTime.Now,
                PlaylistId = 1
            }
        );
    }
}