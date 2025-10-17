using Spotifai_Back.DAL;
class MusicaController
{
    MusicaDAO musicaDAO = new MusicaDAO();
    public void Adicionar(Musica musica)
    {
        musica.DataPublicacao = DateTime.Now;
        // artista i/album id aqui
        musicaDAO.Adicionar(musica);
    }
    public void RemoverMusica(Musica musica)
    {
        // musicaDAO.Remover(musica);   trocar tipo int por Musica
    }
    public void EditarMusica(Musica musica)
    {
        musica.DataPublicacao = DateTime.Now;
        // Atualizar id do artista/alubum
        musicaDAO.Atualizar(musica);
    }
    public Musica ObterPorId(int id)
    {
        return musicaDAO.ObterPorId(id);
    }

    public List<Musica> ListarMusicas()
    {
        List<Musica> musicas = musicaDAO.ObterTodos();
        return musicas;
    }
}