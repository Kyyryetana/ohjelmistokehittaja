using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mainMenu: //paluupiste päävalikkoon
                int num; //käyttäjälle integer muuttuja
                Console.WriteLine("Valitse jokin alla olevista kymmenestä tehtävästä (1-10): ");
                Console.WriteLine("1. Lasketaan kaksi numeroa yhteen.");
                Console.WriteLine("2. Muutetaan Celsius-asteet Fahrenheiteiksi.");
                Console.WriteLine("3. Tehdään kaikki 4. peruslaskutoimitusta.");
                Console.WriteLine("4. Lasketaan jakojäännös.");
                Console.WriteLine("5. Kirjoitetaan viesti käyttäjälle.");
                Console.WriteLine("6. Lasketaan kaksi numeroa yhteen (käyttäjä antaa numerot).");
                Console.WriteLine("7. Muutetaan Celsius-asteet Fahrenheiteiksi (käyttäjä antaa numerot).");
                Console.WriteLine("8. Tehdään kaikki 4. peruslaskutoimitusta (käyttäjä antaa numerot).");
                Console.WriteLine("9. Lasketaan jakojäännös (käyttäjä antaa numerot).");
                Console.WriteLine("10. Lasketaan käyttäjän antamasta luvusta kymmenen kertotaulu.");

                try //kokeillaan että käyttäjä antoi kokonaisluvun
                {
                    num = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex) //käyttäjä ei antanut kokonaislukua
                {
                    Console.WriteLine(ex); //virhekoodin tulostus
                    Console.WriteLine("Antamasi syöte ei kelvannut");
                    Console.ReadLine();
                    goto mainMenu; //paluu alkuun
                }

                switch (num) //tehtävät jaettuna allekkain switch case tyylillä
                {
                    case 1:
                        LaskeYhteen(3, 5);
                        break;
                    case 2:
                        Fahrenheiteiksi(10);
                        break;
                    case 3:
                        Peruslaskutoimitukset(8, 5);
                        break;
                    case 4:
                        Jakojaannos(5, 2);
                        break;
                    case 5:
                        Viesti();
                        break;
                    case 6:
                        LaskeYhteenKauttajanLuvut();
                        break;
                    case 7:
                        FahrenheiteiksiKauttajanLuku();
                        break;
                    case 8:
                        PeruslaskutoimituksetKauttajanLuvuista();
                        break;
                    case 9:
                        JakojaannosKauttajanLuvuista();
                        break;
                    case 10:
                        KertotauluKauttajanLuvusta();
                        break;
                    default:
                        Console.WriteLine("Et antanut lukua väliltä 1-10, kokeile uudelleen.");
                        Console.ReadLine();
                        goto mainMenu; //luku ei ollut sopiva minkään casen kanssa, joten palataan takaisin tehtävän valitsemiseen
                }
        }
        static void LaskeYhteen(int a, int b)
        {
            Console.WriteLine("Lukujen summa on: " + (a + b));
            Console.ReadLine();
        }
        static void Fahrenheiteiksi(int a)
        {
            Console.WriteLine(a + " Celsius-astetta muutettuna Fahrenheitiksi on: " + ((a * 1.8) + 32));
            Console.ReadLine();
        }
        static void Peruslaskutoimitukset(int a, int b)
        {
            Console.WriteLine("Summa: " + a + " + " + b + " = " + (a + b));
            Console.WriteLine("Erotus: " + a + " - " + b + " = " + (a - b));
            Console.WriteLine("Tulo: " + a + " * " + b + " = " + (a * b));
            Console.WriteLine("Osamäärä: " + a + " / " + b + " = " + (double)a / b);
            Console.ReadLine();
        }
        static void Jakojaannos(int a, int b)
        {
            int jakoj = a % b;
            Console.WriteLine("Lukujen " + a + " ja " + b);
            Console.WriteLine("Jakojäännös on " + jakoj);
            Console.ReadLine();
        }
        static void Viesti()
        {
            Console.WriteLine("Anna tähän etunimesi: ");
            string etuNimi = Console.ReadLine();
            Console.WriteLine("Hei " + etuNimi);
            Console.ReadLine();
        }
        static void LaskeYhteenKauttajanLuvut()
        {
            //try catchit tänne ja muihin
            int eka, toka;
            Console.WriteLine("Lasken yhteen kaksi antamaasi kokonaislukua");
            Console.WriteLine("Anna 1. kokonaisluku: ");
            eka = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Anna 2. kokonaisluku");
            toka = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Antamiesi kokonaislukujen summa on: " + (eka+toka));
            Console.ReadLine();
        }
        static void FahrenheiteiksiKauttajanLuku()
        {
            
        }
        static void PeruslaskutoimituksetKauttajanLuvuista()
        {

        }
        static void JakojaannosKauttajanLuvuista()
        {

        }
        static void KertotauluKauttajanLuvusta()
        {

        }
        }
       
} 
