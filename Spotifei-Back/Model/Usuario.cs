
public abstract class Usuario
{
    public int Id { get; set; }

    public string NomeDoUsuario { get; set; }

    public string Email { get; set; }

    public string Senha { get; set; }

    public int Status { get; set; }

    public string? Foto { get; set; }
    public list<Playlist> Playlists { get; set; }

    public abstract void ReproduzirMusica();

    public abstract void CurtirMusica();

    public abstract void CriarPlaylist();

    public abstract void AdicionarMusicaPlaylist();

    public abstract void Logar();
}