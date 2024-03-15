using System;

namespace Special
{
    class Program
    {
        /// <summary>
        /// Asks for a number and receives it and then starts the method GetSpecial
        /// </summary>
        /// <param name="args">Not used here</param>
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of special sequence: ");
            int count1 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(count1));
        }

        /// <summary>
        /// Function that gives the the result of (n-1) + (n-2)*2
        /// </summary>
        /// <param name="count">The value of n in the n times the 
        ///                     method loops</param>
        /// <returns>Returns the result of the special</returns>
        private static int GetSpecial(int count)
        {
            int result;

            if (count <= 0)
            {
                result = 0;
            }
            else if (count == 1)
            {
                result = 1;
            }
            else
            {
                result = GetSpecial(count - 1) + (GetSpecial(count-2) * 2);
            }

            return result;
        }
    }
}
