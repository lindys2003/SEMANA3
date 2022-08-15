using System;

namespace Ejecicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Elijió la opción {0} ", option);
                    break;
                case 2:
                    Console.WriteLine("Elijió la opción {0} ", option);
                    break;
                case 3:
                    Console.WriteLine("Elijió la opción {0} ", option);
                    break;
                case 4:
                    Console.WriteLine("Elijió la opción {0} ", option);
                    break;
                case 5:
                    Console.WriteLine("Elijió la opción {0} ", option);
                    break;
                default:
                    Console.WriteLine("Esta opción no esta disponble");
                    break;




            }
        }
    }
}
