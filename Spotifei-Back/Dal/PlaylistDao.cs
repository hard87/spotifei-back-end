using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifai_Back.DAL
{
    public class PlaylistDAO : IDAO <Playlist>
    {
       private SpotifeiContext contexto = new SpotifeiContext();
        public void Cadastrar(Playlist playlist)
    {
        contexto.Playlists.Add(playlist);
        contexto.SaveChanges();
    }

        public List<Playlist> ListarTodos()
    {
        return contexto.Playlists.ToList();
    }

       public Playlist ListarPorId(int id)
    {
        Playlist? playlist = null;
        playlist = contexto.Playlists.FirstOrDefault(
            playlist => playlist.Id == id
        );
        return playlist;
    }

        public void Atualizar(Playlist playlist)
    {
        contexto.Playlists.Update(playlist);
        contexto.SaveChanges();
    }

        public void Excluir(Playlist playlist)
    {
        contexto.Playlists.Remove(playlist);
        contexto.SaveChanges();
    }
    }
}