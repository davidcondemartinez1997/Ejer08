using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer08
{
    public class TurboMix : ICocina
    {
        public Plato PesarYCocinar(Alimento Alimento1, Alimento Alimento2)
        {
            IBascula bascula = new BasculaService();
            int Peso1 = bascula.Pesar(Alimento1);
            int Peso2 = bascula.Pesar(Alimento2);
            ICocina cocina = new CocinaService();
            cocina.Calentar(Alimento1, Alimento2);

            return new Plato(Alimento1, Alimento2);

        }
        public int Pesar(Alimento Alimento1, Alimento Alimento2)
        {
            this.Calentar(Alimento1, Alimento2);
            return Alimento1.Peso;
        }

        public void Calentar(Alimento Alimento1, Alimento Alimento2)
        {
            CocinaService cocina = new CocinaService();
            cocina.Calentar(Alimento1, Alimento2);
        }
    }
}
