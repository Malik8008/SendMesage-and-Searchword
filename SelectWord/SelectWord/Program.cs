using System;

namespace SelectWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cumleni daxil edin");
            string word = Console.ReadLine();
            Console.WriteLine("Axtarmaq istediyiniz sozu yazin");
            string searched = Console.ReadLine();
            bool answer = word.Selection(searched);
            Console.WriteLine(answer) ;
        }
    }
}
