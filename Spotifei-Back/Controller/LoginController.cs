class LoginController
{
    public bool Autenticar(string nome,string senha)
    {
        Usuario usuario = Indentificar(nome,senha);
        if(usuario != null)
        {
            return true;
        }
        return false;
    }
    public Usuario Indentificar(string nome,string senha)
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        List<Usuario> usuarios = usuarioDAO.ListarTodos();
        var usuario = usuarios.Find(a => a.Nome == nome && a.Senha == senha);
        return usuario;
    }
}