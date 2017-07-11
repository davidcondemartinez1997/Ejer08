using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer08
{
    public class Alimento : IAlimento
    {
        public string Nombre { get; set; }
        public bool Calentado { get; set; }
        int IAlimento.Peso
        {
            get
            {
                return Peso;
            }

            set
            {
                Peso = value;
            }
        }

        public int Peso;

        public Alimento()
        {
            Nombre = "Alimento";
            Peso = 0;
            Calentado = false;
        }

        public Alimento(string Nombre, int Peso, bool Calentado)
        {
            this.Nombre = Nombre;
            this.Peso = Peso;
            this.Calentado = Calentado;
        }
    }
}
