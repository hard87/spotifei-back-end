class AlbumController
{
    static int id = 1;
    public void CriarAlbum(string nome,Artista artista)
    {
        AlbumDAO albumDAO = new AlbumDAO();
        Album album = new Album();
        album.Id = id;
        id++;
        album.Nome = nome;
        album.DataCriacaao = DateTime.Now;
        album.Artista = artista;
        albumDAO.Cadastrar(album);
        
    }

    public void AdicionarMusicas(Musica musica,Album album)
    {
        album.Musicas.Add(musica);
        album.NumeroMusicas = album.Musicas.Count;
    }

    public List<Album> ListarAlbums()
    {
        AlbumDAO albumDAO = new AlbumDAO();
        List<Album> albums = albumDAO.ListarTodos();
        return albums;
    }
}