using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace module04
{
    internal class homework01
    {
        static void Main()
        {
            string url = "http://example.com/nonexistentpage";

            try
            {
                using (WebClient client = new WebClient())
                {
                    string content = client.DownloadString(url);
                    Console.WriteLine("ресурс: " + content);
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ошибка: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}