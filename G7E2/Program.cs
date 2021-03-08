using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G7E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i = 0;
            try
            {
                Console.WriteLine("Ingrese el numero de * que quiere que imprima...");
                num = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato de numero no es el correcto...");
                Console.WriteLine("El programa se cerrara...");
                Console.ReadKey();
                return;
            }
            Console.Clear();
            do
            {
                Console.Write('*');
                i++;
            }
            while (num != i);
            Console.ReadKey();
        }
    }
}
