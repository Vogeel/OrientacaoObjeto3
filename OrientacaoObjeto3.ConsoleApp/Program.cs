using System;

namespace OrientacaoObjeto3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro CalculoCilindro = new Cilindro();

            CalculoCilindro.altura = 5;
            CalculoCilindro.raio = 2.5;
            Console.WriteLine($"O volume do cilindro é de {CalculoCilindro.Volume():F2}");
            Console.ReadKey();
        }
    }
}
