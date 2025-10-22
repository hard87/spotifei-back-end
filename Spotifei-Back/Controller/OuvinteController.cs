using System.Diagnostics.Contracts;
using Spotifai_Back.DAL;
class OuvinteController : IController<Ouvinte>
{
    OuvinteDAO ouvinteDAO = new OuvinteDAO();
    public Ouvinte ObterPorId(int id)
    {
        return ouvinteDAO.ObterPorId(id);
    }

    public void Adicionar(Ouvinte objeto)
    {
        ouvinteDAO.Adicionar(objeto);
    }

    public void Remover(Ouvinte objeto)
    {
        // ouvinteDAO.Remover(objeto);
    }

    public void Editar(Ouvinte objeto)
    {
        ouvinteDAO.Atualizar(objeto);
    }

    public List<Ouvinte> ListarTodos()
    {
        return ouvinteDAO.ObterTodos();
    }
}