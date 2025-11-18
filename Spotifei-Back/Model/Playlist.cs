
public class Playlist
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataCriacao { get; set; }
    public int NumeroMusicas { get; set; }
    public Usuario Usuario { get; set; }
    public int UsuarioId { get; set; }
    public List<Musica> Musicas { get; set; } 
}