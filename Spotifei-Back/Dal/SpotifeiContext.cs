using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

class SpotifeiContext : DbContext
{
    public DbSet<Ouvinte> Ouvintes { get; set; }
    public DbSet<Musica> Musicas { get; set; }
    string stringConexao = "Server=localhost;Port=3306;Database=Spotifei;Uid=root";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Usuario>().HasMany(a => a.Postagens)
            .WithOne(f => f.Usuario)
            .HasForeignKey(f => f.UsuarioId);

        builder.Entity<Ouvinte>().HasData(    
            new Ouvinte()
            {
                Id = 1,
                Email = "ouvinte@senac.br",
                Senha = "ouvinte123",
                NomeDoUsuario = "Ouvinte",
                Status = 1
            }
        );
    }
}