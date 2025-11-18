using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifai_Back.DAL
{
    public class MusicaDAO : IDAO<Musica>
    {
        private SpotifeiContext contexto = new SpotifeiContext();

         public void Cadastrar(Musica objeto)
    {
        contexto.Musicas.Add(objeto);
        contexto.SaveChanges();
    }

      public List<Musica> ListarTodos()
    {
        return contexto.Musicas.ToList();
    }

        public Musica ListarPorId(int id)
    {
        Musica? musica = null;
        musica = contexto.Musicas.FirstOrDefault(
            musica => musica.Id == id
        );
        return musica;
    }

        public void Atualizar(Musica objeto)
    {
        contexto.Musicas.Update(objeto);
        contexto.SaveChanges();
    }

        public void Excluir(Musica objeto)
    {
        contexto.Musicas.Remove(objeto);
        contexto.SaveChanges();
    }
    }
}