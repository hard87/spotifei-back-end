using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifei_Back.DAL
{
    public class MusicaDAO
    {
        private static List<Musica> musicas = new List<Musica>();
        private static int nextId = 1;

        public void Adicionar(Musica musica)
        {
            if (musica == null) throw new ArgumentNullException(nameof(musica));
            musica.Id = nextId++;
            musicas.Add(musica);
        }

        public List<Musica> ObterTodos()
        {
            return new List<Musica>(musicas);
        }

        public Musica ObterPorId(int id)
        {
            return musicas.FirstOrDefault(m => m.Id == id);
        }

        public bool Atualizar(Musica musica)
        {
            if (musica == null) return false;
            var existing = ObterPorId(musica.Id);
            if (existing == null) return false;

            existing.Nome = musica.Nome;
            existing.DataPublicacao = musica.DataPublicacao;
            existing.Artista = musica.Artista;

            return true;
        }

        public bool Remover(int id)
        {
            var musica = ObterPorId(id);
            if (musica == null) return false;
            musicas.Remove(musica);
            return true;
        }
    }
}