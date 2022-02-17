using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoituksia_1_7
{
    internal class Program
    {
        static void Main()
        {
            ///tehtävä 1
            ///tämä ohjelma pyytää käyttäjältä kahta kokonaislukuarvoa ja laittaa ne sitten suuruusjärjestykseen
            string eka;
            string toka;
            Console.Write("Anna ensimmäinen luku: ");
            eka = Console.ReadLine();
            Console.Write("Anna toinen luku: ");
            toka = Console.ReadLine();
            if (Int32.Parse(eka) < Int32.Parse(toka))
                Console.WriteLine(eka + ", " + toka);
            else
                Console.WriteLine(toka + ", " + eka);
            Console.WriteLine("");
            Console.WriteLine("paina ENTER jotta siirryt seuraavaan ohjelmaan");
            Console.ReadLine();

            ///tehtävä 2
            ///tämä ohjelma etsii suurimman kolmesta kokonaisluvusta
            
            
            
        }
    }
}
