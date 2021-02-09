using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace legyenaneve
{
    class Program
    {
        struct Adatgyujtes
        {
            public string felhasznalo;
            public string nem;
            public int oraszam;
        }
        static void Main(string[] args)
        {
            Adatgyujtes[] adatok = new Adatgyujtes[1000];
            Elsofel(adatok);

            Console.WriteLine("\n2. feladat:");
            Masodikfel(adatok);

            Console.WriteLine("\n3. feladat:");
            Harmadikfel(adatok);

            Console.WriteLine("\n4. feladat:");
            Console.WriteLine(Negyedikfel(adatok));

            Console.WriteLine("\n5. feladat:");
            Console.WriteLine(Otodikfel(adatok));

            Console.WriteLine("\n6. feladat:");
            Hatodikfel(adatok);

            Console.WriteLine("\n7. feladat:");
            Hetedikfel(adatok);

            Console.WriteLine("\n8. feladat:");
            Nyolcadikfel(adatok);
            Console.ReadKey();
        }
        static void Elsofel(Adatgyujtes[] adatok)
        {
            string sor = "";
            int sorszam = 0;
            StreamReader file = new StreamReader("szavazas.txt");
            file.ReadLine().Skip(1);

            while ((sor = file.ReadLine()) != null)
            {
                string[] temp = sor.Split(' ');
                adatok[sorszam].felhasznalo = temp[0];
                adatok[sorszam].nem = temp[1];
                adatok[sorszam].oraszam = int.Parse(temp[2]);

                sorszam++;
            }

            file.Close();
        }
        static void Masodikfel(Adatgyujtes[] adatok)
        {
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i].oraszam >= 40)
                {
                    Console.WriteLine(adatok[i].felhasznalo + " " + adatok[i].nem + " " + adatok[i].oraszam);
                }
            }
        }


        static void Harmadikfel(Adatgyujtes[] adatok)
        {
            bool x = false;
            Console.Write("Adja meg az azonosítóját: ");
            string nev = Console.ReadLine();
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i].felhasznalo == nev)
                {
                    x = true;
                }
            }
            if (x)
            {
                Console.WriteLine("Ez az azonosító már szavazott!");
            }
            if (x == false)
            {
                Console.Write("Adja meg a nemét: ");
                string nem = Console.ReadLine();
                Console.Write("Adja meg az oraszamot: ");
                int szam = int.Parse(Console.ReadLine());
                adatok[824].felhasznalo = nev;
                adatok[824].nem = nem;
                adatok[824].oraszam = szam;
            }

        }


        static int Negyedikfel(Adatgyujtes[] adatok)
        {
            int sorszam = 0;

            for (int i = 0; i < adatok.Length; i++)
            {

                if (adatok[i].felhasznalo == "nupafu")
                {


                    sorszam++;
                }
            }
            return sorszam;
        }

        static int Otodikfel(Adatgyujtes[] adatok)
        {
            int internetoraszam = 0;
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i].nem == "F")
                {
                    internetoraszam += adatok[i].oraszam;
                }
            }
            return internetoraszam;
        }

        static void Hatodikfel(Adatgyujtes[] adatok)
        {
            StreamWriter f = new StreamWriter("ervenyes.txt");

            HashSet<string> ervenyesszavazatok = new HashSet<string>();
            for (int i = 0; i < adatok.Length; i++)
            {
                ervenyesszavazatok.Add(adatok[i].felhasznalo);
            }

            foreach (string item in ervenyesszavazatok)
            {
                f.WriteLine(item);
            }

            f.Flush();
            f.Close();
        }

        static void Hetedikfel(Adatgyujtes[] adatok)
        {
            for (int i = 0; i < adatok.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < adatok.Length; j++)
                {
                    if (adatok[i].felhasznalo == adatok[j].felhasznalo && i != j)
                    {
                        c++;
                    }
                }
                if (c == 0)
                {
                    Console.WriteLine(adatok[i].felhasznalo);
                }
            }
        }

        static void Nyolcadikfel(Adatgyujtes[] adatok)
        {
            HashSet<string> komolytalanszavazok = new HashSet<string>();
            for (int i = 0; i < adatok.Length; i++)
            {
                int c = 0;
                int k = 0;
                for (int j = 0; j < adatok.Length; j++)
                {
                    if (adatok[i].felhasznalo == adatok[j].felhasznalo && i != j)
                    {
                        c++;
                    }
                }
                if (c >= 2)
                {
                    for (int j = 0; j < adatok.Length; j++)
                    {
                        if (adatok[i].felhasznalo == adatok[j].felhasznalo && i != j && (adatok[i].nem == "N" && adatok[j].nem == "F" || adatok[i].nem == "F" && adatok[j].nem == "N"))
                        {
                            k++;
                        }
                    }
                    if (k > 0)
                    {
                        komolytalanszavazok.Add(adatok[i].felhasznalo);
                    }

                }
            }
            foreach (string item in komolytalanszavazok)
            {
                Console.WriteLine(item);
            }

        }
    }


}
