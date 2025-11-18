using Spotifai_Back.DAL;
class MusicaController //: iController<Musica>
{
 private MusicaDAO musicaDAO = new MusicaDAO();
    public Musica? ListarPorId(int id)
    {
        Musica musica = musicaDAO.ListarPorId(id);

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
        
        musicaDAO.Cadastrar(musica);
    }

    public void Remover(Musica musica)
    {
        musicaDAO.Excluir(musica);
    }

    public void Editar(Musica musica)
    { 
        musicaDAO.Atualizar(musica);
    }


   public List<Musica> ListarTodos()
    {
        return new MusicaDAO().ListarTodos();
    }
}