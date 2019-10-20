using System;


namespace second_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int liczba;
            Console.WriteLine("Podaj wiek");
   
            str = Console.ReadLine();
            

            while (int.TryParse(str, out liczba) == false) // sprawdza czy podales liczbe calkowita
            {
                Console.WriteLine("Musisz podać liczbe calkowita!!!");

                str = Console.ReadLine();
                
            }

            Console.WriteLine(liczba);


            Console.ReadKey();
        }
    }
}
