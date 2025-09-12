class MusicaController
{
    static int id = 1;
    public void Adicionar(string titulo,DateTime duracao,Album album)
    {
        MusicaDAO musicaDAO = new MusicaDAO();
        Musica musica = new Musica();
        musica.Titulo = titulo;
        musica.Duracao = duracao;
        musica.DataPublicacao = DateTime.Now;
        musica.Album = album;
        musica.Id = id;
        id ++;
        musicaDAO.Adicionar(musica);
    }

    public List<Musica> ListarMusicas()
    {
        MusicaDAO musicaDAO = new MusicaDAO();
        List<Musica> musicas = musicaDAO.ListarTodos();
        return musicas;
    }
}