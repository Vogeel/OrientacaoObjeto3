using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto3.ConsoleApp
{
    internal class Cilindro
    {
        public double altura;
        public double raio;
        public double Volume()
        {
            double ValorFInal = 3.14 * raio * raio * altura;
            return ValorFInal;
        }
    }
}
