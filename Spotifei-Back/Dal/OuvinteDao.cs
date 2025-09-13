using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotifai_Back.DAL;

namespace Spotifai_Back.DAL
{
    public class OuvinteDAO
    {
        private static List<Ouvinte> ouvintes = new List<Ouvinte>();
        private static int nextId = 1;

        public void Adicionar(Ouvinte ouvinte)
        {
            if (ouvinte == null) throw new ArgumentNullException(nameof(ouvinte));
            ouvinte.Id = nextId++;
            ouvintes.Add(ouvinte);
        }

        public List<Ouvinte> ObterTodos()
        {
            return new List<Ouvinte>(ouvintes);
        }

        public Ouvinte ObterPorId(int id)
        {
            return ouvintes.FirstOrDefault(o => o.Id == id);
        }

        public bool Atualizar(Ouvinte ouvinte)
        {
            if (ouvinte == null) return false;
            var existing = ObterPorId(ouvinte.Id);
            if (existing == null) return false;

            existing.ReproduzirMusica = ouvinte.ReproduzirMusica;
            existing.CurtirMusica = ouvinte.CurtirMusica;

            return true;
        }

        public bool Remover(int id)
        {
            var ouvinte = ObterPorId(id);
            if (ouvinte == null) return false;
            ouvintes.Remove(ouvinte);
            return true;
        }
    }
}
