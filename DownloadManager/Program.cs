using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace DownloadManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://download.inspire.net.nz/data/5MB.zip", "5MB.zip");
            Console.WriteLine("Slika je skinuta.");
            Console.ReadKey();  
        }
    }
}
