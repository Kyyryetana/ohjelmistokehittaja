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
        alku:
            //tehtävän alku
            string kluku;
            int luku;
            Console.WriteLine("Valitse ohjelma jonka haluat suorittaa: ");
            Console.WriteLine("1. Lukujen järjestäminen");
            Console.WriteLine("2. Suurimman luvun etsiminen kolmesta");
            Console.WriteLine("3. Luvun (0-9) muunto sanaksi");
            Console.WriteLine("4. Suurimman luvun etsiminen viidestä kokonaisluvusta");
            Console.WriteLine("5. Käyttäjän syöttövalinta");
            Console.WriteLine("6. Bonuspisteet");
            Console.WriteLine("7. Luvun (0-999) muunto sanaksi");
            kluku = Console.ReadLine();

            //tarkista onko käyttäjän näppäilemä kokonaisluku vai ei
            try
            {
                luku = Int32.Parse(kluku);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Käytä kokonaislukuja!");
                Console.WriteLine("ENTER");
                Console.ReadLine();
                goto alku;
            }

            switch (luku)
            {
                case 1: LukujenJarjestaminen();
                    break;
                case 2: SuurinKolmesta();
                    break;
                case 3: PieniMuunto();
                    break;
                case 4: SuurinViidesta();
                    break;
                case 5: KayttajanValinta();
                    break;
                case 6: BonusPisteet();
                    break;
                case 7: SuuriMuunto();
                    break;
                default: Console.WriteLine("Syötä luku 1-7 väliltä");
                    Console.WriteLine("ENTER");
                    Console.ReadLine();
                    goto alku;
            }
        }

        static void LukujenJarjestaminen()
        {
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
            Console.ReadLine();
            Main();
        }
        static void SuurinKolmesta() 
        {
            Console.WriteLine("Suurin kolmesta");
            Console.ReadLine();
            Main();
        }
        static void PieniMuunto() 
        {
            Console.WriteLine("Pieni muunto");
            Console.ReadLine();
            Main();
        }
        static void SuurinViidesta() 
        {
            Console.WriteLine("Suurin viidestä");
            Console.ReadLine();
            Main();
        }
        static void KayttajanValinta() 
        {
            Console.WriteLine("Käyttäjän valinta");
            Console.ReadLine();
            Main();
        }
        static void BonusPisteet() 
        {
            Console.WriteLine("Bonuspisteet");
            Console.ReadLine();
            Main();
        }
        static void SuuriMuunto() 
        {
            Console.WriteLine("Suuri muunto");
            Console.ReadLine();
            Main();
        }
    } }
