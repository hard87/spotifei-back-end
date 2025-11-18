using System.Diagnostics.Contracts;
using Spotifai_Back.DAL;
class OuvinteController : IController<Ouvinte>
{
    OuvinteDAO ouvinteDAO = new OuvinteDAO();
     public Ouvinte? ListarPorId(int id)
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

     public void CadastrarOuvinte(Ouvinte ouvinte)
    {
        dao.Cadastrar(ouvinte);
    }

    public void ExcluirOuvinte(Ouvinte ouvinte)
    {
        dao.Excluir(ouvinte);
    }

    public void AtualizarOuvinte(Ouvinte ouvinte)
    {
       
        dao.Atualizar(ouvinte);
    }

    public List<Ouvinte> ListarOuvintes()
    {
        // return new OuvinteDAO().ListarTodos();
        return dao.ListarTodos();
    }
}