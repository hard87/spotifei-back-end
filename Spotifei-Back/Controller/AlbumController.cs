using Spotifai_Back.DAL;
class AlbumController
{
    AlbumDAO albumDAO = new AlbumDAO();
    public void CriarAlbum(Album album)
    {
        albumDAO.Adicionar(album);
    }
    public void EditarAlbum(Album album)
    {
        albumDAO.Atualizar(album);
    }
    public Album ObterPorId(int id)
    {
        return albumDAO.ObterPorId(id);
    }
    public List<Album> ListarAlbums()
    {
        List<Album> albums = albumDAO.ObterTodos();
        return albums;
    }
}