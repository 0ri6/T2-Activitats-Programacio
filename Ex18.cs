using System;

namespace Pt2Activitat18
{
    public class Pt2Activitat18
    {
        public static bool IsValidAge(ref int num)
        {
            return (num > 0 && num < 120);
        }

        public static void Main()
        {
            const string intNum = "Introdueix un número:";
            const string validAge = "L'edat és valida:";
            const string invalidAge = "L'edat NO és valida:";
            int age;
            Console.WriteLine(intNum);
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                IsValidAge(ref age);
                Console.WriteLine(IsValidAge(ref age) ? validAge : invalidAge);

            }
            catch
            {
                Console.WriteLine("Error en el programa");
            }
        }
    }

}