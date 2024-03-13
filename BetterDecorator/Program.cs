using System;

namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// Print a string with characters before and 
        /// after (the number of times specified)
        /// </summary>
        /// <param name="args">arguments needed to run the program.
        /// A string, followed my a char, followed by an int
        /// </param>
        static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0], 
                                    char.Parse(args[1]), 
                                    int.Parse(args[2])));
        }

        private static string Decor (string s, char dec, int rep)
        {
            string result = "";

            for (int i = 1; i <= rep; i++)
            {
                result += dec;
            }

            result += $" {s} ";

            for (int i = 1; i <= rep; i++)
            {
                result += dec;
            }

            return result;
        }
    }
}
