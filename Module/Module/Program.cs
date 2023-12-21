using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> col1 = new List<int>();
            Random random = new Random();
            for (int i = 0; i < random.Next(1, 99); i++)
            {
                col1.Add(i);
            }
            int max1 = 0;
            int x = 0;
            for (int i = 0; i < 99; i++)
            {
                if (col1.ElementAt(i) > max1)
                {
                    max1 = col1.ElementAt(i);
                    x = i;
                }
            }

            col1.RemoveAt(x);
            int max2 = 0;
            for (int i =0; i< 99; i++)
            {
                if (col1.ElementAt(i)> max2);
                {
                    max2 = col1.ElementAt(i);
                }
            }
            Console.WriteLine(max1);
            Console.WriteLine(max2);
            for (int i =0; i< 99; i++)
            {
                if(i%2 == 1)
                {
                    col1.RemoveAt(i);
                }
            }
        }
    }
    
}
