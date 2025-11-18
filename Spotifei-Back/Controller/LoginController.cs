using Spotifai_Back.DAL;
class LoginController
{
 /*   public bool Autenticar(string login, string senha)
    {
        Usuario usuario = Indentificar(login, senha);
        if (usuario != null)
        {
            return true;
        }
        return false;
    }*/

      public bool Autenticar(string email, string senha)
    {
        List<Usuario> usuarios = new UsuarioDAO().ListarTodos();
        
        foreach (Usuario usuario in usuarios)
        {
            if (Usuario.Email == email && Usuario.Senha== senha)
            {
                return true;
            }

        }
        return false;
    } 
    public Usuario Identificar(string login, string senha)
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        List<Usuario> usuarios = usuarioDAO.ObterTodos();
        var usuario = usuarios.Find(a => a.Login == login && a.Senha == senha);
        return usuario;
    }
}