
class OuvinteController : IController<Ouvinte>
{
    OuvinteDAO ouvinteDAO = new OuvinteDAO();
     public Ouvinte? ObterPorId(int id)
    {
        Ouvinte ouvinte = ouvinteDAO.ListarPorId(id);

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
        ouvinteDAO.Cadastrar(ouvinte);
    }

    public void Remover(Ouvinte ouvinte)
    {
        ouvinteDAO.Excluir(ouvinte);
    }

    public void Editar(Ouvinte ouvinte)
    {
       
        ouvinteDAO.Atualizar(ouvinte);
    }

    public List<Ouvinte> ListarTodos()
    {
        // return new OuvinteDAO().ListarTodos();
        return ouvinteDAO.ListarTodos();
    }
}