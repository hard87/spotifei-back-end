using Spotifai_Back.DAL;
class ArtistaController
{
    ArtistaDAO artistaDAO = new ArtistaDAO();
    public void Cadastrar(Artista artista)
    {
        artistaDAO.Adicionar(artista);
    }
    public void Remover(Artista artista)
    {
        // artistaDAO.Remover(artista);     futuramente trocar id por artista
    }
    public void Editar(Artista artista)
    {
        artistaDAO.Atualizar(artista);
    }
    public List<Artista> ListarArtistas()
    {
        List<Artista> artistas = artistaDAO.ObterTodos();
        return artistas;
    }
    public Artista ObterPorId(int id)
    {
        return artistaDAO.ObterPorId(id);
    }
}