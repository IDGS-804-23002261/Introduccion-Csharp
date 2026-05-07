using System;
using System.Collections.Generic;
using System.Text;

namespace ejemploCsharp
{
    internal class Practica1
    {
        static void Main(string[] args)
        {
            // int, string, bool, double, char
            int cal1 = 0;
            int cal2, cal3, resultado;
            string dato1;
            Console.WriteLine("Ingresa primera calificación: ");
            dato1 = Console.ReadLine();
            cal1 = Convert.ToInt32(dato1);
            Console.WriteLine("Ingresa segunda calificación: ");
            dato1 = Console.ReadLine();
            cal2 = Convert.ToInt32(dato1);
            int suma = cal1 + cal2;

            Console.WriteLine("La suma de las calificaciones es: " + suma);

            // If-else 

            if (cal1 > cal2)
            {
                Console.WriteLine("La nota mayor es: " + cal1);
            }
            else
            {
                Console.WriteLine("La nota mayor es: " + cal2);
            }

            // While

            int x;
            x = 1;
            while (x <= 100)
            {
                Console.Write(x);
                Console.Write(" - ");
                x++;
            }
            // do while



        }
    }
}
