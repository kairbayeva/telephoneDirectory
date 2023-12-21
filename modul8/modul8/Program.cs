using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8
{
    public class RangeOfArray
    {
        int[] array = null;
        public RangeOfArray()
        {
            array = new int[10];
            Random random = new Random();
            for(int i =0; i< array.Length; i++)
            {
                array[i] = random.Next(0,20);
            }
        }
        public int this [int index]
        {
            get
            {
              if (index > 0 && index<= array.Length)
                {
                    return array[index - 1];
                }
              else
                {
                    throw new Exception();
                }
            }
        }
        public override string ToString()
        {
            string result = " ";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray rangeOfArray = new RangeOfArray();
            Console.WriteLine(rangeOfArray);
            //Console.WriteLine(rangeOfArray[0]);
            Console.WriteLine(rangeOfArray[3]);
         
        }
    }
}


    