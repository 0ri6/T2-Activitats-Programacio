using System;
using Classes;

namespace Exercici1
{
    public class Program {
        public static void Main()
        {
            string Msg1 = "Introdueix un número: ";

            Console.WriteLine(Msg1);
            string input = Console.ReadLine();

            int num;

            /*Amb el TryParse, convert tots els strings afegits a enter*/
            if (int.TryParse(input, out num))
            {
                bool IsNatural = Functions.IsNatural(num);
            }

            /*Si el número és més gran o igual a 0, es un número natural*/
            if (num >= 0)
            {
                Console.WriteLine("El " + num + " es un número natural");
            }

            /*En canvi, si el número és més petit a 0, per tant negatiu, NO es un número natural*/
            else if (num < 0)
            {
                Console.WriteLine("El " + num + " NO es un número natural");
            }

            /*Si no es ni més gran, ni igual, ni més petit de 0, NO hi ha número existent*/
            else
            {
                Console.WriteLine("NO HAS INTRODUIT UN NÚMERO ENTER!!");
            }
        }
    }
}
