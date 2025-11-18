using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class AlbumDAO : IDAO <Album>
     {
        private SpotifeiContext contexto = new SpotifeiContext();

         public void Cadastrar(Album objeto)
    {
        contexto.Albuns.Add(objeto);
        contexto.SaveChanges();
    }

      public List<Album> ListarTodos()
    {
        return contexto.Albuns.ToList();
    }

        public Album ListarPorId(int id)
    {
        Album? album = null;
        album = contexto.Albuns.FirstOrDefault(
            album => album.Id == id
        );
        return album;
    }

        public void Atualizar(Album objeto)
    {
        contexto.Albuns.Update(objeto);
        contexto.SaveChanges();
    }

        public void Excluir(Album objeto)
    {
        contexto.Albuns.Remove(objeto);
        contexto.SaveChanges();
    }
    }