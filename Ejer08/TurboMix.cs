using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer08
{
    public class TurboMix
    {
        public int Pesar (Alimento Alimento1)
        {
            return Alimento1.Peso;
        }

        public int Pesar(Alimento Alimento1, Alimento Alimento2)
        {
            this.Calentar(Alimento1, Alimento2);
            return Alimento1.Peso;
        }

        public Plato Calentar (Alimento Alimento1, Alimento Alimento2)
        {
            Console.Write("Se ha calentado " + Alimento1.Nombre + " y " + Alimento2.Nombre);
            Plato plato = this.CocinarPlato(Alimento1, Alimento2);
            return plato;
        }

        public Plato CocinarPlato(Alimento Alimento1, Alimento Alimento2)
        {
            Console.Write("Se ha preparado el plato que tiene " + Alimento1.Nombre + " y " + Alimento2.Nombre);
            Plato plato = new Plato(Alimento1, Alimento2);
            return plato;
        }
    }
}
