using System;

namespace BetterDecorator
{
    /// <summary>
    /// Main class of the program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Print a string with characters before and 
        /// after (the number of times specified)
        /// </summary>
        /// <param name="args">Arguments needed to run the program.
        /// A string, followed by a char, followed by an int
        /// </param>
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                Console.WriteLine(Decor(args[0], 
                                    char.Parse(args[1]), 
                                    int.Parse(args[2])));
            }
            else
                Console.WriteLine(Decor());
        }

        /// <summary>
        /// Grabs the given values and returns a string
        /// </summary>
        /// <param name="s">The main string</param>
        /// <param name="dec">The char to be repeated</param>
        /// <param name="rep">Number of times the char will be repeated</param>
        /// <returns>Returns a string</returns>
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

        /// <summary>
        /// Overload of the Decor method for when there's no arguments given
        /// </summary>
        /// <returns>Sends a specific Decor with 3 arguments</returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
