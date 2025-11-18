using Spotifai_Back.DAL;
class MusicaController //: iController<Musica>
{
 private MusicaDAO musicaDAO = new MusicaDAO();
    public Musica? ListarPorId(int id)
    {
        Musica musica = dao.ListarPorId(id);

        if (musica != null)
        {
            return musica;
        }
        else
        {
            return null;
        }
    }
      public void Adicionar(Musica musica)
    {
        
        dao.Cadastrar(musica);
    }

    public void Remover(Musica musica)
    {
        dao.Excluir(musica);
    }

    public void Editar(Musica musica)
    { 
        dao.Atualizar(Musica);
    }


   public List<Musica> ListarTodos()
    {
        return new MusicaDAO().ListarTodos();
    }
}