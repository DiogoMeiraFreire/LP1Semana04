using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0], 
                                    char.Parse(args[1]), 
                                    int.Parse(args[2])));
        }

        private static string Decor (string s, char dec, int rep)
        {
            string result = "";

            for (int i = 0; i <= rep; i++)
            {
                result += dec;
            }

            result += $" {s} ";

            for (int i = 0; i <= rep; i++)
            {
                result += dec;
            }

            return result;
        }
    }
}
