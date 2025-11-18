using System.Diagnostics.Contracts;
using Spotifai_Back.DAL;
class OuvinteController : IController<Ouvinte>
{
    OuvinteDAO ouvinteDAO = new OuvinteDAO();
     public Ouvinte? ObterPorId(int id)
    {
        Ouvinte ouvinte = dao.ListarPorId(id);

        if (ouvinte != null)
        {
            return ouvinte;
        }
        else
        {
            return null;
        }
    }

     public void Adicionar(Ouvinte ouvinte)
    {
        dao.Cadastrar(ouvinte);
    }

    public void Remover(Ouvinte ouvinte)
    {
        dao.Excluir(ouvinte);
    }

    public void Editar(Ouvinte ouvinte)
    {
       
        dao.Atualizar(ouvinte);
    }

    public List<Ouvinte> ListarTodos()
    {
        // return new OuvinteDAO().ListarTodos();
        return dao.ListarTodos();
    }
}