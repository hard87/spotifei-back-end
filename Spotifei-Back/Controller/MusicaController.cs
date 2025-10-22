using Spotifai_Back.DAL;
class MusicaController : IController<Musica>
{
    MusicaDAO musicaDAO = new MusicaDAO();
    public Musica ObterPorId(int id)
    {
        return musicaDAO.ObterPorId(id);
    }
    public void Adicionar(Musica objeto)
    {
        musicaDAO.Adicionar(objeto);
    }

    public void Remover(Musica objeto)
    {
        // musicaDAO.Remover(objeto);
    }

    public void Editar(Musica objeto)
    {
        musicaDAO.Atualizar(objeto);
    }

    public List<Musica> ListarTodos()
    {
        return musicaDAO.ObterTodos();
    }
}