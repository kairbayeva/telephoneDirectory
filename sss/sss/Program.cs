using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Exmpl01()
        {
            Console.Write("Enter your firstname and lastname:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
        static void Exmpl02()
        {
            Console.Write("Enter a:");
            string strA = Console.ReadLine();
            int A = 0;
            A = Convert.ToInt32(strA);
            Console.Write("Enter b:");
            string strB = Console.ReadLine();
            int B = 0;
            B = Convert.ToInt32(strB);
            int Sum = A + B;
            Console.WriteLine("Sum = " + Sum);

        }
        static void Main(string[] args)
        {
            Exmpl02();

        }
        static void Exmpl04(int x)
        {
            x = x + 1;
        }
        static void Exmpl05(User user)
        {
            user.Age = user.Age + 1;
        }
        public class User
        {
            public int Age { get; set; }

        }

    }
}