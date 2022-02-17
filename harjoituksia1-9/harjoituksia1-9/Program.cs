using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoituksia1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///tehtävät 1-5 
            ///en oikein ymmärtänyt että mitä niissä haettiin?

            ///tehtävä 6
            string x, y;
            int summa;
            Console.Write("Anna ensimmäinen luku: ");
            x = Console.ReadLine();
            Console.Write("Anna toinen luku: ");
            y = Console.ReadLine();
            summa = Int32.Parse(x) + Int32.Parse(y);
            Console.WriteLine(" ");
            Console.WriteLine("Antamiesi lukujen summa on: " + summa);
            Console.ReadLine();


            ///tehtävä 7
            int erotus;
            erotus = Int32.Parse(x) - Int32.Parse(y);
            Console.WriteLine("Antamiesi lukujen erotus on: " + erotus);
            Console.ReadLine();


            ///tehtävä 8
            int tulo;
            tulo = Int32.Parse(x) * Int32.Parse(y);
            Console.WriteLine("Antamiesi lukujen tulo on: " + tulo);
            Console.ReadLine();


            ///tehtävä 9
            double osamaara;
            osamaara = (double) Int32.Parse(x) / Int32.Parse(y);
            Console.WriteLine("Antamiesi lukujen osamäärä on: " + osamaara);
            Console.ReadLine();
        }
    }
}
