class ArtistaController
{
    static int id;
    public void Cadastrar(string senha,string login)
    {
        ArtistaDAO artistaDAO = new ArtistaDAO();
        Artista artista = new Artista();
        artista.Login = login;
        artista.Senha = senha;
        artista.Id = id;
        id++;
        artistaDAO.Cadastrar(artista)
    }
    public List<Artista> ListarArtistas()
    {
        ArtistaDAO artistaDAO = new ArtistaDAO();
        List<Artista> artistas = artistaDAO.ListarTodos();
        return artistas;
    }
}