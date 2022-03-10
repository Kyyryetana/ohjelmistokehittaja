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
            //ohjelman alku
            string kluku;
            int luku;
            Console.WriteLine("Valitse ohjelma jonka haluat suorittaa ja paina ENTER: ");
            Console.WriteLine("1. Lukujen järjestäminen");
            Console.WriteLine("2. Suurimman luvun etsiminen kolmesta");
            Console.WriteLine("3. Luvun (0-7) muunto sanaksi");
            Console.WriteLine("4. Suurimman luvun etsiminen viidestä kokonaisluvusta");
            Console.WriteLine("5. Käyttäjän syöttövalinta");
            Console.WriteLine("6. Bonuspisteet");
            Console.WriteLine("7. Luvun (0-999) muunto sanaksi");
            kluku = Console.ReadLine();

            //tarkista onko käyttäjän näppäilemä kokonaisluku vai ei
            try
            {
                luku = Int32.Parse(kluku); //on kokonaisluku
            }
            catch (Exception ex) // ei ole kokonaisluku
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Käytä kokonaislukuja!");
                Console.WriteLine("ENTER");
                Console.ReadLine();
                goto alku; //palaa ohjelman alkuun
            }

            switch (luku) //tarkista minkä numeron käyttäjä antoi ja siirrä sen funktion luokse
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
                default:
                    Console.WriteLine("Syötä luku 1-7 väliltä"); //käyttäjän antama luku ei vastannut mitään sallituista
                    Console.WriteLine("ENTER");
                    Console.ReadLine();
                    goto alku; //palaa ohjelman alkuun
            }
        }

        static void LukujenJarjestaminen() //ensimmäinen ohjelma
        { alku: //tänne palataan virhe tilanteissa
            string eka, toka; //merkkijono muuttujat
            int eka1, toka2; //kokonaisluku muuttujat
            Console.Write("Anna ensimmäinen luku: ");
            eka = Console.ReadLine();
            Console.Write("Anna toinen luku: ");
            toka = Console.ReadLine();

            try //testataan onko käyttäjän antama luku kokonaisluku
            {
                eka1 = Int32.Parse(eka);
                toka2 = Int32.Parse(toka);
            }
            catch (Exception ex) //käyttäjä antoi jotain muuta kuin kokonaislukuja
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Käytä kokonaislukuja!");
                Console.WriteLine("ENTER");
                Console.ReadLine();
                goto alku; //palaa kyseisen ohjelman alkuun
            }

            if (Int32.Parse(eka) < Int32.Parse(toka)) //verrataan annettujen kokonaislukujen suuruutta
                Console.WriteLine(eka1 + ", " + toka2);
            else
                Console.WriteLine(toka2 + ", " + eka1);
            Console.ReadLine();
            Main();
        }

        static void SuurinKolmesta() //toinen ohjelma
        {
            int[] luvut = new int[3]; //array muuttujan tekeminen
        alku: // kyseisen ohjelman alku

            try // pyydetään käyttäjältä 3 kokonaislukua
            {
                Console.WriteLine("Anna 1. kokonaisluku: ");
                luvut[0] = Int32.Parse(Console.ReadLine()); // tarkistetaan että luvut ovat kokonaislukuja
                Console.WriteLine("Anna 2. kokonaisluku: ");
                luvut[1] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna 3. kokonaisluku: ");
                luvut[2] = Int32.Parse(Console.ReadLine());
            }

            catch (Exception ex) // luvut eivät olleet kokonaislukuja joten palataan kysymään ne uudelleen
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luvut eivät olleet kokonaislukuja");
                goto alku;
            }

            Array.Sort(luvut); // järjestä luvut suuruusjärjestykseen
            int suurin = luvut.Length; //lukujen määrä arrayssä
            Console.WriteLine("Suurin luku oli: " + luvut[suurin - 1]); // lukuja on arrayssä 4 joten valitaan viimeinen - 1
            Console.WriteLine("paina ENTER");
            Console.ReadLine();

            Main(); // palataan koko ohjelman alkuun
        }
        static void PieniMuunto() //kolmas ohjelma
        {
        alku: //palataan kyseisen ohjelman alkuun virhe tilanteessa
            string annettuluku;
            int numeroluku;

            Console.WriteLine("Ohjelma pyytää sinulta kokonaislukuja 0-7 ja muuttaa ne sanaksi");
            Console.Write("Anna luku joka muutetaan sanaksi: ");
            annettuluku = Console.ReadLine(); //käyttäjältä pyydetään kokonaisluku ja tallennetaan se muuttujaan annettuluku

            try
            {
                numeroluku = Int32.Parse(annettuluku); //kokeillaan että onko käyttäjän antama arvo kokonaisluku
            }

            catch (Exception ex) //ei ollut, palautetaan kyseisen ohjelman alkuun
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luku ei ollut kokonaisluku");
                Console.WriteLine("ENTER");
                Console.ReadLine();
                goto alku;
            }

            switch (numeroluku) //verrataan käyttäjän antamaa lukua switch case funktiolla
            {
                case 0:
                    Console.WriteLine("Nolla");
                    Console.ReadLine();
                    break;
                case 1:
                    Console.WriteLine("Yksi");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Kaksi");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Kolme");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Neljä");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Viisi");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Kuusi");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Seitsemän");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Antamasi luku ei ollut väliltä 0-7"); //luku ei ollut väliltä 0-7, käyttäjä palautetaan kyseisen ohjelman alkuun
                    Console.WriteLine("Kokeile uudelleen painamalla ENTER");
                    Console.ReadLine();
                    goto alku;
            }

            Main(); //koko ohjelman alkuun palautus
        }
        static void SuurinViidesta() //neljäs ohjelma
        {
            int[] luvut = new int[5]; //array muuttujan tekeminen
        alku: // kyseisen ohjelman alku

            try // pyydetään käyttäjältä 5 kokonaislukua
            {
                Console.WriteLine("Anna 1. kokonaisluku: ");
                luvut[0] = Int32.Parse(Console.ReadLine()); // tarkistetaan että luvut ovat kokonaislukuja
                Console.WriteLine("Anna 2. kokonaisluku: ");
                luvut[1] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna 3. kokonaisluku: ");
                luvut[2] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna 4. kokonaisluku: ");
                luvut[3] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna 5. kokonaisluku: ");
                luvut[4] = Int32.Parse(Console.ReadLine());
            }

            catch (Exception ex) // luvut eivät olleet kokonaislukuja joten palataan kysymään ne uudelleen
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luvut eivät olleet kokonaislukuja");
                goto alku;
            }

            Array.Sort(luvut); // järjestä luvut suuruusjärjestykseen
            int suurin = luvut.Length; //lukujen määrä arrayssä ja suurin muuttujan määrittäminen
            Console.WriteLine("Suurin luku oli: " + luvut[suurin - 1]); // lukuja on arrayssä 6 joten valitaan viimeinen - 1
            Console.WriteLine("paina ENTER");
            Console.ReadLine();

            Main(); // palataan koko ohjelman alkuun
        }
        static void KayttajanValinta() //viides ohjelma
        {
            int kokoluku; //muuttujat integer, doudle ja string
            double desiluku;
            string merkkijono, syote;
        valintaalku: //palautuspiste
            Console.WriteLine("Minkä tyyppisen tiedon haluat syöttää (int, double, string (i/d/s)): ");
            syote = Console.ReadLine();

            if (syote == "i" || syote == "d" || syote == "s" || syote == "I" || syote == "D" || syote == "S") //jos syöte on?
            {
                switch (syote) //switch case vaihtoehdot
                {
                    case "i":
                    case "I":
                    intalku: //interer palautuspiste
                        Console.Write("Syötä kokonaisluku: ");
                        try
                        {
                            kokoluku = Int32.Parse(Console.ReadLine()); //tarkista kokonaisluku
                            Console.WriteLine("Annoit luvun: " + kokoluku);
                            Console.ReadLine();
                        }

                        catch (Exception ex) //ei ollut kokonaisluku
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Ei ollut kokonaisluku tämä");
                            Console.WriteLine("paina ENTER");
                            Console.ReadLine();
                            goto intalku;
                        }
                        break;
                    case "d":
                    case "D":
                    doublealku: //double palautuspiste
                        Console.WriteLine("Syötä desimaaliluku: ");
                        try
                        {
                            desiluku = Double.Parse(Console.ReadLine()); //onko desimaaliluku
                            Console.WriteLine("Annoit desimaaliluvun " + desiluku);
                            Console.ReadLine();
                        }

                        catch (Exception ex) //ei ollut desimaali
                        {
                            Console.WriteLine(ex.Message); //kyseisen virheen viesti
                            Console.WriteLine("Anna desimaaliluku!");
                            Console.WriteLine("paina ENTER");
                            Console.ReadLine();
                            goto doublealku; // doublen palautuspisteeseen
                        }
                        break;
                    case "s":
                    case "S":
                    stringalku: //string palautuspiste
                        Console.WriteLine("Syötä merkkijono: ");
                        merkkijono = Console.ReadLine(); //merkkijono siirretty merkkijono muuttujaan
                        Console.WriteLine("Merkkijono on: " + merkkijono);
                        Console.ReadLine();
                        break;
                    default: // joku meni koodissa pieleen
                        Console.WriteLine("Hmm, jokin meni vikaan");
                        Console.WriteLine("paina ENTER");
                        Console.ReadLine();
                        goto stringalku; //stringin alkuun alkuun
                }
            }
            else //jos käyttäjä syöttää muuta kuin sallitut
            {
                Console.WriteLine("Kokeile käyttää kirjaimia (i/d/s) ja yritä uudelleen");
                Console.WriteLine("paina ENTER");
                Console.ReadLine();
                goto valintaalku; //palauttaa tehtävän alkuun
            }

            Main(); //palauttaa ohjelman alkuun
        }
        static void BonusPisteet() //kuudes ohjelma
        {
            int bonus;
        bonusalku:
            Console.WriteLine("Anna bonusten määrä välillä 1-9: ");

            try
            {
                bonus = Int32.Parse(Console.ReadLine());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi arvo ei ollut kokonaisluku, yritä uudelleen");
                Console.WriteLine("paina ENTER");
                Console.ReadLine();
                goto bonusalku;
            }

            switch (bonus)
            {
                case 1:
                case 2:
                case 3:
                    bonus *= 3;
                    break;
                case 4:
                case 5:
                case 6:
                    bonus *= 100;
                    break;
                case 7:
                case 8:
                case 9:
                    bonus *= 1000;
                    break;
                default:
                    Console.WriteLine("Antamasi arvo ei ollut väliltä 1-9, yritä uudelleen");
                    Console.WriteLine("paina Enter");
                    Console.ReadLine();
                    goto bonusalku;
            }
            Console.WriteLine("Lopullinen bonuksesi on: " + bonus);
            Console.WriteLine("paina ENTER");
            Console.ReadLine();

            Main();
        }
        static void SuuriMuunto() //käytännössä kopio opettajan koodista, koska en saanut toimimaan. valittaa jatkuvasti c#kielen versiosta ja
            //jouduin myös poistamaan static lauseet koodista jotta sen sai toimimaan? mikä on homman nimi?
        {
            int numero;
        suurialku:
            Console.WriteLine("Anna kokonaisluku väliltä 0-999 jonka haluat että ohjelma muuttaa tekstiksi: ");

            try
            {
                numero = Int32.Parse(Console.ReadLine());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi arvo ei ollut kokonaisluku, yritä uudelleen");
                Console.WriteLine("paina ENTER");
                Console.ReadLine();
                goto suurialku;
            }

            if (numero > 999 || numero < 0)
            {
                Console.WriteLine("Annoit luvun, joka ei ole välillä 0-999.");
                Console.ReadLine();
                goto suurialku;
            }
            else if (numero < 10)
            {
                string ykkonen;
                ykkonen = ykkoset(numero);
                Console.WriteLine(ykkonen);
            }
            else if (numero < 20)
            {
                string pkymmenen;
                pkymmenen = poikkeuskymmenet(numero);
                Console.WriteLine(pkymmenen);
            }
            else if (numero < 100)
            {
                string kymmenen;
                kymmenen = kymmenet(numero);
                Console.WriteLine(kymmenen);
            }
            else if (numero < 1000)
            {
                string sata;
                sata = sadat(numero);
                Console.WriteLine(sata);
            }

            string ykkoset(int number)
            {
                switch (number)
                {
                    case 1:
                        return "Yksi";
                        break;
                    case 2:
                        return "Kaksi";
                        break;
                    case 3:
                        return "Kolme";
                        break;
                    case 4:
                        return "Neljä";
                        break;
                    case 5:
                        return "Viisi";
                        break;
                    case 6:
                        return "Kuusi";
                        break;
                    case 7:
                        return "Seitsemän";
                        break;
                    case 8:
                        return "Kahdeksan";
                        break;
                    case 9:
                        return "Yhdeksän";
                        break;
                    default:
                        return "Eij";
                        break;
                }
            }
            string poikkeuskymmenet(int number)
            {
                switch (number)
                {
                    case 10:
                        return "Kymmenen";
                        break;
                    case 11:
                        return "Yksitoista";
                        break;
                    case 12:
                        return "Kaksitoista";
                        break;
                    case 13:
                        return "Kolmetoista";
                        break;
                    case 14:
                        return "Neljätoista";
                        break;
                    case 15:
                        return "Viisitoista";
                        break;
                    case 16:
                        return "Kuusitoista";
                        break;
                    case 17:
                        return "Seitsemäntoista";
                        break;
                    case 18:
                        return "Kahdeksantoista";
                        break;
                    case 19:
                        return "Yhdeksäntoista";
                        break;
                    default:
                        return "Eij";
                        break;
                }
            }
            string kymmenet(int number)
            {
                string x = Convert.ToString(number);
                string eka = x.Substring(0, 1);
                string toka = x.Substring(1, 1);
                number = Int32.Parse(eka);
                int toinen = Int32.Parse(toka);
                string y = ykkoset(toinen);
                switch (number)
                {
                    case 2:
                        return "Kaksikymmentä " + y;
                        break;
                    case 3:
                        return "Kolmekymmentä " + y;
                        break;
                    case 4:
                        return "Neljäkymmentä " + y;
                        break;
                    case 5:
                        return "Viisikymmentä " + y;
                        break;
                    case 6:
                        return "Kuusikymmentä " + y;
                        break;
                    case 7:
                        return "Seitsemänkymmentä " + y;
                        break;
                    case 8:
                        return "Kahdeksankymmentä " + y;
                        break;
                    case 9:
                        return "Yhdeksänkymmentä " + y;
                        break;
                    default:
                        return "Eij";
                        break;
                }

            }
            string sadat(int number)
            {
                string x = Convert.ToString(number);
                string y;
                string eka = x.Substring(0, 1);
                string toka = x.Substring(1, 2);
                string ptoka = x.Substring(1, 1);
                number = Int32.Parse(eka);
                int toinen = Int32.Parse(toka);
                if (ptoka == "1")
                {
                    y = poikkeuskymmenet(toinen);
                }
                else
                {
                    y = kymmenet(toinen);
                }
                switch (number)
                {
                    case 1:
                        return "Sata" + y;
                        break;
                    case 2:
                        return "Kaksisataa " + y;
                        break;
                    case 3:
                        return "Kolmesataa " + y;
                        break;
                    case 4:
                        return "Neljäsataa " + y;
                        break;
                    case 5:
                        return "Viisisataa " + y;
                        break;
                    case 6:
                        return "Kuusisataa " + y;
                        break;
                    case 7:
                        return "Seitsemänsataa " + y;
                        break;
                    case 8:
                        return "Kahdeksansata a" + y;
                        break;
                    case 9:
                        return "Yhdeksänsataa " + y;
                        break;
                    default:
                        return "Eij";
                        break;
                }
            }
            Console.Write("Aloitetaanko alusta (k/e)?");
            string vastaus = Console.ReadLine();
            if (vastaus == "k" || vastaus == "K")
            {
                goto suurialku;
            }
        } } }
