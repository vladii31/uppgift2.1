using System;
namespace uppgift2._1
{
    class Program
    {
        public static object Read { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("vilken är din favoritbok ?");
            string boknam = Console.ReadLine();
            Console.WriteLine(boknam + "Programering 1");
            Console.ReadKey();

        }
    }
}
