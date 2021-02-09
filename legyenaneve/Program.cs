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

            Console.WriteLine("\n3. feladat:");
            Console.Write("Adjon meg egy azonosítót: ");
            string azonosito = Console.ReadLine();
            Console.Write("Adja meg a nemét: ");
            string nem = Console.ReadLine();
            Console.Write("Adja meg,jhetente hány órát tölt internetezéssel: ");
            string ora = Console.ReadLine();

            Console.WriteLine("\n4. feladat:");

            Console.WriteLine("\n5. feladat:");
            Console.WriteLine(Otodikfel(adatok));

            Console.WriteLine("\n6. feladat:");
            Hatodikfel(adatok);

            Console.WriteLine("\n7. feladat:");
            Hetedikfel(adatok);

            Console.WriteLine("\n8. feladat:");

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
        static void Masodikfel()
        {
            string sor = "";
            int elsosor = 0;
            bool ElsoSor = true;
            while ((sor = file.ReadLine()) != null)
            {
                if (ElsoSor)
                {
                    elsosor = int.Parse(sor);
                    ElsoSor = false;
                }
                else
                {
                    int SorHossz = sor.Length;
                    int Meghaladta40et = SorHossz - 2;


                    Meghaladta40et++;
                }

            }
            file.Close();

            int sorszam = 0;
            int meghaladta_40et = 0;
            for (int i = 0; i < sorszam; i++)
            {
                if (adatok[i][3] >= 40)
                {
                    string[] temp = adatok[i].Split(' ');
                    for (int j = 0; j < temp[2].Length; j++)
                    {
                        if (temp[2][j] >= 40)
                        {
                            meghaladta_40et++;
                        }

                    }
                }
            }
            Console.WriteLine("Adatok ahol az óraszámok meghaladták a 40-et: ", meghaladta_40et);

        }

        static void Harmadikfel(Adatgyujtes[] adatok)
        {
            string x;
            char t;
            for (int i = 0; i < length; i++)
            {
                x = Console.ReadLine().ToUpper();
                t = x[0];

                if (adatok[i].Contains(t))
                {

                    Console.WriteLine("Ezt az azonosítót már valaki használta, írjon be egy újat: ", t);
                    continue;
                }

            }




        }

        static void Negyedikfel()
        {
            int sorszam = 0;

            for (int i = 0; i < adatok.Length; i++)
            {

                if (adatok[i].felhasznalo == "nupafu")
                {


                    sorszam++;
                }
            }

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

        static void Nyolcadikfel()
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
