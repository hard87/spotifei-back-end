using Spotifai_Back.DAL;
class ArtistaController : IController <Artista>
{
    ArtistaDAO artistaDAO = new ArtistaDAO();

    public void Adicionar(Artista objeto)
    {
        artistaDAO.Cadastrar(objeto);
    }

    public void Editar(Artista objeto)
    {
        artistaDAO.Atualizar(objeto);
    }

    public List<Artista> ListarTodos()
    {
        return artistaDAO.ListarTodos();
    }

    public Artista ObterPorId(int id)
    {
        return artistaDAO.ListarPorId(id);
    }

    public void Remover(Artista objeto)
    {
        artistaDAO.Excluir(objeto);
    }
}