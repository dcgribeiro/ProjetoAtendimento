using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAtendimento.Models;

namespace ProjetoAtendimento.Controllers
{
    class Guiches
    {
        private List<Guiche> listaGuiches;
        public List<Guiche> ListaGuiches { get { return listaGuiches; } }

        public Guiches() {
            listaGuiches = new List<Guiche>();
        }

        public void adicionar(Guiche guiche) {
            listaGuiches.Add(new Guiche(listaGuiches.Count + 1));
        }
    }
}
