// See https://aka.ms/new-console-template for more information
string lopetus;
do
{
    int valinta;
    mainmenu:
    Console.Clear();
    Console.WriteLine("Valitse alla olevista ohjelmista se mitä haluat käyttää (1-7): ");
    Console.WriteLine("1. Käyttäjän ikä.");
    Console.WriteLine("2. Luvun toisto.");
    Console.WriteLine("3. Sanan ensimmäisen ja viimeisen kirjaimen vaihto.");
    Console.WriteLine("4. Tarkistus, ovatko annetut luvut positiivisia vai negatiivisia.");
    Console.WriteLine("5. Pisimmän sanan tulostus.");
    Console.WriteLine("6. Parittomien lukujen tulostus.");
    Console.WriteLine("7. Kolmella jaollisten lukujen tulostus.");

    try
    {
        valinta = Int32.Parse(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Antamasi arvo ei ollut kokonaisluku. Yritä uudelleen.");
        Console.ReadLine();
        goto mainmenu;
    }

    switch (valinta)
    {
        case 1:
            KayttajanIka();
            break;
        case 2:
            LuvunToisto();
            break;
        case 3:
            KirjaintenVaihto();
            break;
        case 4:
            LuvunEtumerkki();
            break;
        case 5:
            PisinSana();
            break;
        case 6:
            Parittomat();
            break;
        case 7:
            KolmellaJaolliset();
            break;
        default:
            Console.WriteLine("Et valinnut lukua väliltä 1-7. Yritä uudeleen.");
            goto mainmenu;
            break;
    }

    static void KayttajanIka()
    {
        int ika;
        ikaalku:
        Console.WriteLine("Antaisitko tähän ikäsi kokonaislukuna: ");

        try
        {
            ika = Int32.Parse(Console.ReadLine());
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Antamasi arvo ei ollut kokonaisluku. Yritä uudelleen.");
            Console.ReadLine();
            goto ikaalku;
        }

        Console.WriteLine("{0} näytät ikäistäsi nuoremmalta!", ika);
        Console.ReadLine();
    }

    static void LuvunToisto()
    {
        int luku;
        LTalku:
        try
        {
            Console.Clear();
            Console.WriteLine("Ole hyvä ja anna suurempi kokonaisluku kuin 10: ");
            luku = Int32.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Antamasi luku ei ollut kokonaisluku. Yritä uudelleen.");
            Console.ReadLine();
            goto LTalku;
        }

        for (int i = 0; i < luku; i++)
        {
            for (int j = 0; j < luku; j++)
            {
                Console.Write(luku + " ");
            }

            Console.WriteLine();

            for (int k = 0; k < luku; k++)
            {
                Console.Write(luku);
            }

            Console.WriteLine();
        }
    }

    static void KirjaintenVaihto()
    {
        //harjoittele tätä ja tee alusta
        /*string sana, uusisana;
        int pituus;
        Console.Clear();
        Console.Write("Anna sana, jonka ensimmäinen ja viimeinen kirjain vaihdetaan keskenään: ");
        sana = Console.ReadLine();
        pituus = sana.Length;
        char[] taulu = new char[pituus];
        for (int i = 0; i < pituus; i++)
            taulu[i] = sana[i];
        taulu[0] = sana[pituus - 1];
        taulu[pituus - 1] = sana[0];
        uusisana = String.Join("", taulu);
        Console.WriteLine("Annoit sanan {0} ja se on muutettuja {1}", sana, uusisana);*/
    }

    static void LuvunEtumerkki()
    {
        int luku1, luku2;
        LEalku:
        Console.Clear();
        Console.WriteLine("Tämä ohjelma pyytää käyttäjältä kahta lukua ja tarkastaa niiden etumerkit.");

        try
        {
            Console.Write("Anna ensimmäinen kokonaisluku: ");
            luku1 = Int32.Parse(Console.ReadLine());
            Console.Write("Anna toinen kokonaisluku: ");
            luku2 = Int32.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Antamasi arvot eivät olleet kokonaislukuja. Yritä uudelleen: ");
            goto LEalku;
        }

        if (luku1 >= 0 && luku2 >= 0)
        {
            Console.WriteLine("Luvut ovat positiivisia");
            Console.ReadLine();
        }
        else if (luku1 < 0 && luku2 < 0)
        {
            Console.WriteLine("Luvut ovat negatiivisia");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Luvuista toinen on positiivinen ja toinen negatiivinen");
            Console.ReadLine();
        }
    }

    static void PisinSana()
    {
        //kokeile myös toista tapaa math tyylillä kun kerkeät
        Console.Clear();
        Console.WriteLine("Ohjelma pyytää käyttäjältä lausetta ja palauttaa lauseen pisimmän sanan.");

        string lause;
        Console.Write("Anna lause: ");
        lause = Console.ReadLine();

        string[] taulu = lause.Split(' ');
        string pisin = taulu[0];

        for (int i = 1; i < taulu.Length; i++)
        {
            if (taulu[i].Length > pisin.Length)
            {
                pisin = taulu[i];
            }
        }

        Console.WriteLine("Antamasi lause oli {0}, jonka pisin sana oli {1}.", lause, pisin);
        Console.ReadLine();
    }

    static void Parittomat()
    {
        Console.Clear();
        Console.WriteLine("Tämä ohjelma tulostaa parittomat luvut väliltä 1-99");

        for (int i = 1; i <= 99; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
        Console.ReadLine();
    }

    static void KolmellaJaolliset()
    {
        Console.Clear();
        Console.WriteLine("Tämä ohjelma tulostaa kolmella jaolliset luvut väliltä 1-99");

        for (int i = 3; i <= 99; i += 3)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
        Console.ReadLine();
    }

    //ohjelman lopettelu
    Console.WriteLine("Haluatko lopettaa? 0 + Enter lopettaaksesi. Mikä muu tahansa jatkaa.");
    lopetus = Console.ReadLine();

} while (lopetus != "0");
