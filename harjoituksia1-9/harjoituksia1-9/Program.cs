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
            ///yhteen lasku
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


            ///vähennys lasku
            int erotus;
            erotus = Int32.Parse(x) - Int32.Parse(y);
            Console.WriteLine("Antamiesi lukujen erotus on: " + erotus);
            Console.ReadLine();


            ///kerto lasku
            int tulo;
            tulo = Int32.Parse(x) * Int32.Parse(y);
            Console.WriteLine("Antamiesi lukujen tulo on: " + tulo);
            Console.ReadLine();


            ///jako lasku
            int osamaara;
            osamaara = Int32.Parse(x) / Int32.Parse(y);
            Console.WriteLine("Antamiesi lukujen osamäärä on: " + osamaara);
            Console.ReadLine();

            ///kesken
        }
    }
}
