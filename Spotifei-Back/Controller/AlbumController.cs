
class AlbumController : IController <Album>
{
    AlbumDAO albumDAO = new AlbumDAO();
    public Album ObterPorId(int id)
    {
        return albumDAO.ListarPorId(id);
    }
    public void Adicionar(Album objeto)
    {
        albumDAO.Cadastrar(objeto);
    }

    public void Remover(Album objeto)
    {
        albumDAO.Excluir(objeto);
    }

    public void Editar(Album objeto)
    {
        albumDAO.Atualizar(objeto);
    }

    public List<Album> ListarTodos()
    {
        List<Album> albums = albumDAO.ListarTodos();
        return albums;
    }
}