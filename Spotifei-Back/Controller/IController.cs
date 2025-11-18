interface IController <T>
{
    public void Adicionar(T objeto);
    public void Remover(T objeto);
    public void Editar(T objeto);
    public T ObterPorId(int id);
    public List<T> ListarTodos();
}