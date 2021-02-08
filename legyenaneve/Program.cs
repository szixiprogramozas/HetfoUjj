using System;
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

            Console.WriteLine("\n7. feladat:");

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
    
    
        }

        static void Hetedikfel(Adatgyujtes[] adatok)
        {
        
    
        }

        static void Nyolcadikfel()
        {
    
    
        }
    }

    
}
