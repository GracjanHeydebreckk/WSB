using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Napisz program ktory za pomoca petli for zsumuje liczby nieparzyste ez przedzialu <1;10>

namespace _3_file
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 1)
                { suma = suma + i; }
                
            }
            Console.WriteLine(suma); Console.WriteLine(); Console.WriteLine();
            // Napisz program, ktory wyswietli duze litery alfabetu od A do Z oraz od Z do A z wykorzystaniem pętli for

            char znak = 'A';
            for (;znak<='Z';znak++)
            {
                Console.Write(znak);
                if (znak<'Z')
                    Console.Write(", ");
                else
                    Console.WriteLine(".");
                
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            //napisz program, ktory za pomoca instrukcji while dla danych wartosci x zmieniajacych sie w przedziale (0;10) oblicza wartosc funkcji y=4x
            int x = 0;
            int y;
            while(x<11)
            {
                y=4*x;
                Console.Write("x= {0}   ",x);
                Console.WriteLine("y= {0}",y);
                x++;
            }

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            for (int z = 1; z < 11; z++)
            {
                for (int o = 1; o < 11; o++)
                {
                    Console.Write(o*z); Console.Write("  ");

                }
                Console.WriteLine();
            }
            // uzytkownik podaje swoj wiek z klawiatury z przedzialu od 1 do 120 wykorzystaj do while

            Console.WriteLine("Podaj swoj wiek");
            string wiek = Console.ReadLine(); int wiekl;

            int.TryParse(wiek, out wiekl);
            do
            { Console.WriteLine("Twoj wiek to {0}", wiekl);
                wiek = Console.ReadLine();

            } while ((wiekl<1) && (wiekl > 121));
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            int a = 1, b = 1;
            while(a<11)
            {
                while(b<11)
                { Console.Write(a * b); Console.Write("   "); b++; }
                Console.WriteLine(); a++;
            }

            Console.ReadKey();
        }
    }
}
