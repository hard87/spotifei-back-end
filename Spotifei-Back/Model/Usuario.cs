abstract class Usuario
{
    public int Id { get; set; }

    public string Login { get; set; }

    public string Senha { get; set; }
    public abstract void ReproduzirMusica();

    public abstract void CurtirMusica();

    public abstract void CriarPlaylist();

    public abstract void AdicionarMusicaPlaylist();

    public abstract void Logar();
}