using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifai_Back.DAL
{
    public class UsuarioDAO : IDAO<Usuario>
    {
       private SpotifeiContext contexto = new SpotifeiContext();
        public void Cadastrar(Usuario usuario)
    {
        contexto.Usuarios.Add(usuario);
        contexto.SaveChanges();
    }

          public List<Usuario> ListarTodos()
    {
        return contexto.Usuarios.ToList();
    }

       public Usuario ListarPorId(int id)
    {
        Usuario? usuario = null;
        usuario = contexto.Usuarios.FirstOrDefault(
            usuario => usuario.Id == id
        );
        return usuario;
    }

        public void Atualizar(Usuario usuario)
    {
        contexto.Usuarios.Update(usuario);
        contexto.SaveChanges();
    }

        public void Excluir(Usuario usuario)
    {
        contexto.Usuarios.Remove(usuario);
        contexto.SaveChanges();
    }
    }
}
