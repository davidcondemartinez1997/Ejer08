using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer08
{
    public class TurboMix : ICocina
    {
        public IBascula Bascula { get; set; }
        public ICocina Cocina { get; set; }

        public TurboMix(IBascula _Bascula, ICocina _Cocina)
        {
            this.Bascula = _Bascula;
            this.Cocina = _Cocina;
        }

        public Plato PesarYCocinar(Alimento Alimento1, Alimento Alimento2)
        {
            int Peso1 = Bascula.Pesar(Alimento1);
            int Peso2 = Bascula.Pesar(Alimento2);
            Cocina.Calentar(Alimento1, Alimento2);

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
