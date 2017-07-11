using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer08
{
    public class CocinaService : ICocina
    {
        public void Calentar(Alimento Alimento1, Alimento Alimento2)
        {
            Alimento1.Calentado = true;
            Alimento2.Calentado = true;
        }
        
    }
}
