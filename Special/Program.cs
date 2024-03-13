using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of special sequence: ");
            int count1 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(count1));
        }

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
