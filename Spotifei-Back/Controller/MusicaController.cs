using Spotifai_Back.DAL;
class MusicaController
{
    static int id = 1;
    public void Adicionar(string titulo, Artista artista)
    {
        MusicaDAO musicaDAO = new MusicaDAO();
        Musica musica = new Musica();
        musica.Nome = titulo;
        musica.DataPublicacao = DateTime.Now;
        musica.Artista = artista;
        musica.Id = id;
        id++;
        musicaDAO.Adicionar(musica);
    }

    public List<Musica> ListarMusicas()
    {
        MusicaDAO musicaDAO = new MusicaDAO();
        List<Musica> musicas = musicaDAO.ObterTodos();
        return musicas;
    }
}