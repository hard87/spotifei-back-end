using Spotifai_Back.DAL;
class AlbumController : IController<Album>
{
    AlbumDAO albumDAO = new AlbumDAO();
    public Album ObterPorId(int id)
    {
        return albumDAO.ObterPorId(id);
    }
    public void Adicionar(Album objeto)
    {
        albumDAO.Adicionar(objeto);
    }

    public void Remover(Album objeto)
    {
        // albumDAO.Remover(objeto);
    }

    public void Editar(Album objeto)
    {
        albumDAO.Atualizar(objeto);
    }

    public List<Album> ListarTodos()
    {
        List<Album> albums = albumDAO.ObterTodos();
        return albums;
    }
}