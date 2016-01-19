using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace WCF_Labb2ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BMIClient host = new BMIClient();
            Console.WriteLine();
            Console.WriteLine("Skriv in din längd: ");
            var height = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Skriv in din vikt: ");
            var weight = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(host.BMI(height, weight));
            Thread.Sleep(5000);
        }
    }
}
