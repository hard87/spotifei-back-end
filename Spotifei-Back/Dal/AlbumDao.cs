using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifei_Back.DAL
{
    public class AlbumDAO
    {
        private static List<Album> albums = new List<Album>();
        private static int nextId = 1;

        public void Adicionar(Album album)
        {
            if (album == null) throw new ArgumentNullException(nameof(album));
            album.Id = nextId++;
            albums.Add(album);
        }

        public List<Album> ObterTodos()
        {
            return new List<Album>(albums);
        }

        public Album ObterPorId(int id)
        {
            return albums.FirstOrDefault(a => a.Id == id);
        }

        public bool Atualizar(Album album)
        {
            if (album == null) return false;
            var existing = ObterPorId(album.Id);
            if (existing == null) return false;

            existing.Nome = album.Nome;
            existing.DataCriacao = album.DataCriacao;
            existing.Artista = album.Artista;
            existing.Musicas = album.Musicas;

            return true;
        }

        public bool Remover(int id)
        {
            var album = ObterPorId(id);
            if (album == null) return false;
            albums.Remove(album);
            return true;
        }
    }
}