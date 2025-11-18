public class Musica : Postagem
{
   /*  public int Id { get; set; }
    public string Nome{ get; set; }
    public DateTime DataPublicacao { get; set; }
    public Artista Artista { get; set; }
*/
public int Id { get; set; }
    public string Descricao { get; set; }
    public DateTime DataPublicacao { get; set; }
    public Usuario Usuario { get; set; }
    public int UsuarioId { get; set; }
}