using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer08
{
    public class Plato
    {
        public Alimento Alimento1;
        public Alimento Alimento2;

        public Plato() { }
        public Plato(Alimento Alimento1, Alimento Alimento2)
        {
            this.Alimento1 = Alimento1;
            this.Alimento2 = Alimento2;
        }
    }
}
