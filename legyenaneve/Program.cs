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
        static void Elsofel(Adatgyujtes[]adatok)
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
    
        
        }

        static void Harmadikfel()
        {
    
    
        }

        static void Negyedikfel()
        {
        
    
        }

        static int Otodikfel(Adatgyujtes[] adatok)
        {
            int internetoraszam = 0;
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i].nem=="F")
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
                    if (adatok[i].felhasznalo == adatok[j].felhasznalo && i!=j)
                    {
                        c++;
                    }
                }
                if (c==0)
                {
                    Console.WriteLine(adatok[i].felhasznalo);
                }   
            }
        }

        static void Nyolcadikfel()
        {
    
    
        }
    }

    
}
