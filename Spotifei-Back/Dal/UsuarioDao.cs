using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifei_Back.DAL
{
    public class UsuarioDAO
    {
        private static List<Usuario> usuarios = new List<Usuario>();
        private static int nextId = 1;

        public void Adicionar(Usuario usuario)
        {
            if (usuario == null) throw new ArgumentNullException(nameof(usuario));
            usuario.Id = nextId++;
            usuarios.Add(usuario);
        }

        public List<Usuario> ObterTodos()
        {
            return new List<Usuario>(usuarios);
        }

        public Usuario ObterPorId(int id)
        {
            return usuarios.FirstOrDefault(u => u.Id == id);
        }

        public bool Atualizar(Usuario usuario)
        {
            if (usuario == null) return false;
            var existing = ObterPorId(usuario.Id);
            if (existing == null) return false;

            existing.Login = usuario.Login;
            existing.Senha = usuario.Senha;

            return true;
        }

        public bool Remover(int id)
        {
            var usuario = ObterPorId(id);
            if (usuario == null) return false;
            usuarios.Remove(usuario);
            return true;
        }
    }
}
