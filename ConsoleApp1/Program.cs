using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numeroRandom = rand.Next(0, 101);
            int numeroUsuario;
            int intentos = 0;
            do
            {
                numeroUsuario = int.Parse(Console.ReadLine());
                if (numeroUsuario > numeroRandom)
                {
                    Console.WriteLine("El numero ingresado es mayor al numero elegido.");
                    intentos++;
                }
                else if (numeroUsuario < numeroRandom)
                {
                    Console.WriteLine("El numero ingresado es menor al numero elegido");
                    intentos++;
                }
                else if (numeroUsuario == numeroRandom)
                {
                    Console.WriteLine("Adivinaste! Te tomó " + intentos + " intentos.");
                }
            } while (numeroRandom != numeroUsuario);
        }
    }
}
