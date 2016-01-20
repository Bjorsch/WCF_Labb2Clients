using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WCF_Labb2ConsoleClient1000
{
    public class Program
    {
        static void Main(string[] args)
        {
            BirthdayClient host = new BirthdayClient();
            Console.WriteLine("Vilket år är du född? ");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vilken månad? ");
            var month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Och dag? ");
            var day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nästa gång du fyller jämt 1000 dagar är om " + host.To1000(year, month, day) + " dagar");
            Thread.Sleep(5000);
        }
    }
}
