using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotifei_Back.DAL;


namespace Spotifei_Back.DAL
{
    public class OuvinteDAO
    {
      private SpotifeiContext contexto = new SpotifeiContext();

       public void Cadastrar(Ouvinte ouvinte)
    {
        contexto.Ouvintes.Add(ouvinte);
        contexto.SaveChanges();
    }

        public List<Ouvinte> ListarTodos()
    {
        return contexto.Ouvintes.ToList();
    }
          public Ouvinte ListarPorId(int id)
    {
        Ouvinte? ouvinte = null;
        ouvinte = contexto.Ouvintes.FirstOrDefault(
            ouvinte => ouvinte.Id == id
        );
        return ouvinte;
    }

         public void Atualizar(Ouvinte ouvinte)
    {
        contexto.Ouvintes.Update(ouvinte);
        contexto.SaveChanges();
    }

 public void Excluir(Ouvinte ouvinte)
    {
        contexto.Ouvintes.Remove(ouvinte);
        contexto.SaveChanges();
    }
    }
}
