public class Musica
{
   /*  public int Id { get; set; }
    public string Nome{ get; set; }
    public DateTime DataPublicacao { get; set; }
    public Artista Artista { get; set; }
*/
public int Id { get; set; }
    public string Descricao { get; set; }
    public DateTime DataPublicacao { get; set; }
    public Playlist Playlist { get; set; }
    public int PlaylistId { get; set; }
}