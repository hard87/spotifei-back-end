class LoginController
{
    public bool Autenticar(string login,string senha)
    {
        Usuario usuario = Indentificar(login,senha);
        if(usuario != null)
        {
            return true;
        }
        return false;
    }
    public Usuario Indentificar(string login,string senha)
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        List<Usuario> usuarios = usuarioDAO.ListarTodos();
        var usuario = usuarios.Find(a => a.Login == login && a.Senha == senha);
        return usuario;
    }
}