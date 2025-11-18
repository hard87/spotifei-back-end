using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifai_Back.DAL
{
    public class ArtistaDAO : IDAO<Artista>
    {
        private SpotifeiContext contexto = new SpotifeiContext();

         public void Cadastrar(Artista objeto)
    {
        contexto.Artistas.Add(objeto);
        contexto.SaveChanges();
    }

      public List<Artista> ListarTodos()
    {
        return contexto.Artistas.ToList();
    }

        public Artista ListarPorId(int id)
    {
        Artista? artista = null;
        artista = contexto.Artistas.FirstOrDefault(
            artista => artista.Id == id
        );
        return feedback;
    }

        public void Atualizar(Artista objeto)
    {
        contexto.Artistas.Update(objeto);
        contexto.SaveChanges();
    }

        public void Excluir(Artista objeto)
    {
        contexto.Artistas.Remove(objeto);
        contexto.SaveChanges();
    }
    }
}
