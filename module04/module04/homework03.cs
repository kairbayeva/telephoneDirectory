using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module04
{
    internal class homework03
    {
        static void Main()
        {
            try
            {
                FirstMethod();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();
        }

        static void FirstMethod()
        {
            try
            {
                SecondMethod();
            }
            catch (Exception ex)
            {
                throw new CustomException("Error in FirstMethod", ex);
            }
        }

        static void SecondMethod()
        {
            throw new InvalidOperationException("Error in SecondMethod");
        }
    }

    class CustomException : Exception
    {
        public CustomException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}