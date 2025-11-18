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
      public void PostarMusica(Musica musica)
    {
        
        dao.Cadastrar(musica);
    }

    public void ExcluirMusica(Musica musica)
    {
        dao.Excluir(musica);
    }

    public void AtualizarMusica(Musica musica)
    { 
        dao.Atualizar(musica);
    }


   public List<Musica> ListarMusicas()
    {
        return new MusicaDAO().ListarTodos();
    }
}