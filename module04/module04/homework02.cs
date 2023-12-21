using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module04
{
    internal class homework02
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i = 0; i <= array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Final");
            }
            Console.ReadKey();
        }
    }
}