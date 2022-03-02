using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arvottu;
            Random luku = new Random();

            for (int i = 1; i <= 7; i++)
            {
                arvottu = luku.Next(1, 39);
                Console.Write("{0}, ", arvottu);
            }
            Console.ReadLine();
        }
    }
}
