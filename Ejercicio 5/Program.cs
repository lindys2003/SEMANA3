using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string linea;
            do
            {
                Console.WriteLine("Ingrese uun valor entre 0 y 999 (0 finalizada):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor >= 100)
                {
                    Console.WriteLine("Tiene 3 dígitos.");
                }
                else if (valor >= 10)
                {
                    Console.WriteLine("Tiene 2 dígitos.");
                }
                else
                {
                    Console.WriteLine("Tiene 1 dígito.");
                }

            } while (valor != 0);
        }
    }
}
