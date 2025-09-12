using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifei_Back.DAL
{
    public class ArtistaDAO
    {
        private static List<Artista> artistas = new List<Artista>();
        private static int nextId = 1;

        public void Adicionar(Artista artista)
        {
            if (artista == null) throw new ArgumentNullException(nameof(artista));
            artista.Id = nextId++;
            artistas.Add(artista);
        }

        public List<Artista> ObterTodos()
        {
            return new List<Artista>(artistas);
        }

        public Artista ObterPorId(int id)
        {
            return artistas.FirstOrDefault(a => a.Id == id);
        }

        public bool Atualizar(Artista artista)
        {
            if (artista == null) return false;
            var existing = ObterPorId(artista.Id);
            if (existing == null) return false;

            existing.Nome = artista.Nome;
            existing.DataCriacao = artista.DataCriacao;

            return true;
        }

        public bool Remover(int id)
        {
            var artista = ObterPorId(id);
            if (artista == null) return false;
            artistas.Remove(artista);
            return true;
        }
    }
}
