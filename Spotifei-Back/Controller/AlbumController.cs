class AlbumController
{
    public List<Album> ListarAlbums()
    {
        AlbumDAO albumDAO = new AlbumDAO();
        List<Album> albums = albumDAO.ListarTodos();
        return albums;
    }
}