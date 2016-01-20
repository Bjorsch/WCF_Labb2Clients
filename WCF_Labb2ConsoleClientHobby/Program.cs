using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WCF_Labb2ConsoleClientHobby
{
    class Program
    {
        static void Main(string[] args)
        {
            HobbyClient host = new HobbyClient();
            Console.WriteLine("Skriv in en filmtitel som du vill få veta vilket år den gjordes");
            var movie = Console.ReadLine();
            Console.WriteLine("År: " + host.MovieFromYear(movie));
            Thread.Sleep(5000);
        }
    }
}
