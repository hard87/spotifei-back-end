using Spotifai_Back.DAL;
class ArtistaController : IController<Artista>
{
    ArtistaDAO artistaDAO = new ArtistaDAO();

    public void Adicionar(Artista objeto)
    {
        artistaDAO.Adicionar(objeto);
    }

    public void Editar(Artista objeto)
    {
        artistaDAO.Atualizar(objeto);
    }

    public List<Artista> ListarTodos()
    {
        return artistaDAO.ObterTodos();
    }

    public Artista ObterPorId(int id)
    {
        return artistaDAO.ObterPorId(id);
    }

    public void Remover(Artista objeto)
    {
        // artistaDAO.Remover(objeto);
    }
}