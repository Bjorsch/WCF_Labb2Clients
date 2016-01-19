using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WCF_Labb2ConsoleClientDay
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysClient host = new DaysClient();
            Console.WriteLine("Vilket år är du född? ");
            var year= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vilken månad? ");
            var month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Och dag? ");
            var day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(host.Day(year, month, day));
            Thread.Sleep(5000);
        }
    }
}
