using Spotifai_Back.DAL;
class PlaylistController : IController<Playlist>
{
    PlaylistDAO playlistDAO = new PlaylistDAO();
    public void Adicionar(Playlist objeto)
    {
        playlistDAO.Adicionar(objeto);
    }

    public void Editar(Playlist objeto)
    {
        playlistDAO.Atualizar(objeto);
    }

    public List<Playlist> ListarTodos()
    {
        return playlistDAO.ObterTodos();
    }

    public Playlist ObterPorId(int id)
    {
        return playlistDAO.ObterPorId(id);
    }

    public void Remover(Playlist objeto)
    {
        // playlistDAO.Remover(objeto);
    }
}