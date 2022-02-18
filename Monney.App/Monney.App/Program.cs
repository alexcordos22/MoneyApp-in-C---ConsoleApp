using System;

namespace Money.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bani, priceReno, priceKia, priceAudi;
            Console.WriteLine("Introduceti suma disponibila: ");
            bani = int.Parse(Console.ReadLine());

            priceAudi = 15000;
            priceKia = 20000;
            priceReno = 10000;

            if (bani >= 10000 & bani < 14999)
            {
                Console.WriteLine("Am suficienti bani sa imi cumpar un Reno");
            }
            else if (bani >= 20000)
            {
                Console.WriteLine("Am suficienti bani sa imi cumpar un Kia");
            }
            else if (bani >= 15000 && bani < 19999)
            {
                Console.WriteLine("Am suficienti bani sa imi cumpar un Audi");
            }
            else if (bani < 10000)
            {
                Console.WriteLine("Nu am suficienti bani sa imi cumpar o masina");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("CHANGE MONEY");
            float lei, euro;
            Console.WriteLine("Introduceti suma de lei pe care doriti sa o schimbati: ");
            lei = float.Parse(Console.ReadLine());
            euro = lei / 4.98f;
            Console.WriteLine("Suma de bani pe care o veti primi este: " + euro + " euro");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("AMANET C#");
            float suma, gram, gram2, suma2;
            Console.WriteLine("Introduceti numarul de grame dorit: ");
            gram = float.Parse(Console.ReadLine());
            suma = (float)gram * 220;
            Console.WriteLine("Trebuie sa achitati " + suma + "lei");

            Console.WriteLine("Introduceti numarul de bani disponibili: ");
            suma2 = float.Parse(Console.ReadLine());
            gram2 = (float)suma2 / 220;
            Console.WriteLine("Puteti cumpara " + gram2 + " grame de aur");
        }
    }
}

