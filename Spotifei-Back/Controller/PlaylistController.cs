using Spotifai_Back.DAL;
class PlaylistController : IController<Playlist>
{
    PlaylistDAO playlistDAO = new PlaylistDAO();
    public void Adicionar(Playlist objeto)
    {
        playlistDAO.Cadastrar(objeto);
    }

    public void Editar(Playlist objeto)
    {
        playlistDAO.Atualizar(objeto);
    }

    public List<Playlist> ListarTodos()
    {
        return playlistDAO.ListarTodos();
    }

    public Playlist ObterPorId(int id)
    {
        return playlistDAO.ListarPorId(id);
    }

    public void Remover(Playlist objeto)
    {
        playlistDAO.Excluir(objeto);
    }
}