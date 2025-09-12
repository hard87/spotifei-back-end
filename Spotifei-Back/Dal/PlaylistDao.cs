using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifei_Back.DAL
{
    public class PlaylistDAO
    {
        private static List<Playlist> playlists = new List<Playlist>();
        private static int nextId = 1;

        public void Adicionar(Playlist playlist)
        {
            if (playlist == null) throw new ArgumentNullException(nameof(playlist));
            playlist.Id = nextId++;
            playlists.Add(playlist);
        }

        public List<Playlist> ObterTodos()
        {
            return new List<Playlist>(playlists);
        }

        public Playlist ObterPorId(int id)
        {
            return playlists.FirstOrDefault(p => p.Id == id);
        }

        public bool Atualizar(Playlist playlist)
        {
            if (playlist == null) return false;
            var existing = ObterPorId(playlist.Id);
            if (existing == null) return false;

            existing.Nome = playlist.Nome;
            existing.DataCriacao = playlist.DataCriacao;
            existing.NumeroMusicas = playlist.NumeroMusicas;
            existing.Usuario = playlist.Usuario;
            existing.Musicas = playlist.Musicas;

            return true;
        }

        public bool Remover(int id)
        {
            var playlist = ObterPorId(id);
            if (playlist == null) return false;
            playlists.Remove(playlist);
            return true;
        }
    }
}