using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat01_GaraiGabor14SL
{
    internal class Program
    {
        // A nem megfelelő bemeneti érték esetei nincsenek mindenhol lekezelve!!!
        static void Feladat1_2_3_4() 
        {
            //----------- 1. Kérj be a felhasználótól egy N egész számot -----------

            Console.WriteLine("Kérem, adjon meg egy N egész számot: ");
            int N = Convert.ToInt32(Console.ReadLine());

            //----------- 2. Hozz létre egy N elemű egész számú tömböt -----------
            int[] numbers = new int[N];

            //----------- 3. A tömböt töltsd fel random számokkal (0 és 100 között legyen) -----------
            
            Random random = new Random();
            int parosOssz = 0;
            int paratlanOssz = 0;
            int primOssz= 0;
            int isPrim(int number)
            {
                if (number <= 1)
                {
                    return -1;
                }

                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        return -1;
                    }
                }

                return number;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0,101);

                if (numbers[i] % 2 == 0)
                {
                    parosOssz++;
                }
                else
                {
                    paratlanOssz++;
                }
                if (isPrim(numbers[i])!= -1)
                {
                    primOssz++;
                }

            }
            //----------- 4. Vizsgáld meg a tömb elemeit és írd ki az alábbi adatokat: -----------

            //a páros számokat (hány darab van és hogy mik ezek)

            int[] paros = new int[parosOssz];
            int index = 0;
            foreach (var item in numbers.Where(x => x % 2 == 0))
            {
                paros[index]= item; index++;

            }
            index = 0;

            Console.WriteLine($"a: Páros számok összesen: {parosOssz} melyek a következők:");
            Console.Write("     ");
            for (int i = 0;i < parosOssz; i++) {
                if(i!=parosOssz - 1)
                Console.Write($"{paros[i]},");
                else
                    Console.Write($"{paros[i]}");
            }
            Console.WriteLine();

            //b páratlan számokat (hány darab van és hogy mik ezek)

            int[] paratlan = new int[paratlanOssz];
            foreach (var item in numbers.Where(x => x % 2 != 0))
            {
                paratlan[index] = item; index++;

            }
            index = 0;

            Console.WriteLine($"b: Páratlan számok összesen: {paratlanOssz} melyek a következők:");
            Console.Write("     ");
            for (int i = 0; i < paratlanOssz; i++)
            {
                if (i != paratlanOssz-1)
                    Console.Write($"{paratlan[i]},");
                else
                    Console.Write($"{paratlan[i]}");
            }

            Console.WriteLine();

            //c prím számokat (hány darab van és hogy mik ezek)

            int[] prim = new int[primOssz];
            foreach (var item in numbers.Where(x=>isPrim(x)!=-1))
            {
                prim[index]= item; index++;
            }
            index = 0;

            Console.WriteLine($"c: Prím számok összesen: {primOssz} melyek a következők:");
            Console.Write("     ");
            for (int i = 0; i < primOssz; i++)
            {
                if (i != primOssz-1)
                    Console.Write($"{prim[i]},");
                else
                    Console.Write($"{prim[i]}");
            }

            Console.WriteLine();
            //d a tömb átlaga

            //Megírtam így, mert ez a mostani anyag

            //double avg = 0;
            //for (int i = 0; i< numbers.Length ; i++) {
            //avg+= numbers[i];
            //}
            //avg/= numbers.Length;

            //double avg = numbers.Sum() / numbers.Length;

            double avg = numbers.Average();
            Console.WriteLine($"d: Az átlag: {avg}");

            //e legkisebb szám

            //int min = numbers[0];
            //for(int i = 0; i < numbers.Length; i++) { 
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}
            Console.WriteLine($"e: A legkisebb szám: {numbers.Min()}");

            //f  legnagyobb szám

            //int max = numbers[0];
            //for(int i = 0; i < numbers.Length; i++) { 
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}
            Console.WriteLine($"f: A legnagyobb szám: {numbers.Max()}");

        }
     
        static void Feladat05()
        {
            //----------- 5.Kérj be a felhasználótól 5 szót, tárold el őket egy tömbben és határozd meg a következőket: -----------
           
            Console.WriteLine("Kérem adjon meg 5 szót, szóközzel elválasztva:");
            string[] words = Console.ReadLine().Split(' ');

            // Bekérés, amíg nem 5 db szó érkezik

            while (words.Length != 5) {
                Console.WriteLine("Kérem adjon meg 5 szót, szóközzel elválasztva:");
                 words = Console.ReadLine().Split(' ');
            }

            // Írd ki a legrövidebb begépelt szót

            string shortest = words[0];

            foreach (string word in words)
            {
                if(word.Length < shortest.Length)
                {
                    shortest = word;
                }
            }

            //Írd ki a leghosszabb begépelt szót

            string longest = words[0];

            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }

            //Írd ki, ha van egyező szó

            //string[] ismetlodok = new string[5];
            //int metszetMeret = 0;

            //for (int i = 0; i < words.Length; i++)
            //{
            //    for (int j = 0; j < words.Length; j++)
            //    {
            //        if (words[i] == words[j] && i != j)
            //        {
            //            bool benneVan = false;
            //            for (int k = 0; k < metszetMeret; k++)
            //            {
            //                if (ismetlodok[k] == words[i])
            //                {
            //                    benneVan = true;
            //                    break;
            //                }
            //            }
            //            if (!benneVan)
            //            {
            //                ismetlodok[metszetMeret] = words[i];
            //                metszetMeret++;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine($"A legrövidebb szó: {shortest}");
            //Console.WriteLine($"A leghosszabb szó: {longest}");
            //Console.WriteLine($"{metszetMeret} ismétődő szót találtam:");
            //foreach (string word in ismetlodok) { Console.WriteLine(word); }

            //Írd ki, ha van egyező szó

            var multi = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

            for (int i = 0; i < words.Length; i++)
            {
                if (multi.ContainsKey(words[i]))
                {
                    multi[words[i]]++;
                }
                else
                {
                    multi[words[i]] = 1;
                }

            }

            Console.WriteLine($"A legrövidebb szó: {shortest}");
            Console.WriteLine($"A leghosszabb szó: {longest}");
            Console.WriteLine($"{(multi.Where(x => x.Value > 1)).Count()} ismétődő szót találtam:");
            foreach (KeyValuePair<string, int> item in multi.Where(x => x.Value > 1))
            {
                Console.WriteLine($"{item.Key} : {item.Value} db");
            }

        }

        static void Feladat06()
        {
            //----------- 6.Készítsünk programot, amely kiszámolja a/ b + c / d(két tört összegét), majd az eredmény törzsalakú törté alakítja(amely már nem egyszerűsíthető tovább): -----------

            Console.WriteLine("Kérem adjon meg két törtet: (a/b c/d)");
            string[] valaszt = Console.ReadLine().Split(' ');
            while (valaszt == null) {
                Console.WriteLine("Kérem adjon meg két törtet: (a/b c/d)");
                valaszt = Console.ReadLine().Split(' ');
            }
            string[] elsoString = valaszt[0].Split('/');
            int[] elso = new int[2];
            elso[0] = Convert.ToInt32(elsoString[0]);
            elso[1] = Convert.ToInt32(elsoString[1]);

            string[] masodikString = valaszt[1].Split('/');
            int[] masodik = new int[2];
            masodik[0] = Convert.ToInt32(masodikString[0]);
            masodik[1] = Convert.ToInt32(masodikString[1]);

            //Legnagyobb közös osztó
            int gcd(int a, int b)
            {
                if (a == 0)
                    return b;
                return gcd(b % a, a);
            }

            // Egyszerűstő
            string lowest(int nevezo3, int szamlalo3)
            {
                // Legnagyobb közös osztó
                int oszto = gcd(szamlalo3, nevezo3);

                // Mindkét oldal egyszerűsítése
                nevezo3 = nevezo3 / oszto;
                szamlalo3 = szamlalo3 / oszto;
                return (szamlalo3 + "/" + nevezo3);
            }

            //Függvény, összead két törtet
            string TortekSum(int szamlalo1, int nevezo1, int szamlalo2, int nevezo2)
            {
                // legnagyobb közös osztó a nevezőknek
                int nevezo3 = gcd(nevezo1, nevezo2);

                // Lekisebb közös többszörös keresése nevezo1 és nevezo2 nek
                // LkktM * lnko = a * b
                nevezo3 = (nevezo1 * nevezo2) / nevezo3;

                // szamlalo a végső törtnek
                int szamlalo3 = (szamlalo1) * (nevezo3 / nevezo1) + (szamlalo2) * (nevezo3 / nevezo2);
                return lowest(nevezo3, szamlalo3);
            }

            Console.WriteLine($"{elso[0]}/{elso[1]} + {masodik[0]}/{masodik[1]} = {TortekSum(elso[0], elso[1], masodik[0], masodik[1])}");
        }

        static void Feladat07()
        {
            //----------- 7.Írjunk programot, ami bekér a felhasználótól egy páros számot. Ha a felhasználó nem a feltételnek megfelelő számot ad meg, ismételjük meg a bekérést.Ha a szám megfelelő, írjuk ki a képernyőre: "A megadott szám megfelelő"): -----------

            // Szám bekérése
            Console.WriteLine("Kérem adjon meg egy páros számot:");
            int szam = Convert.ToInt32(Console.ReadLine());

            // Ismétlés, amíg nem megfelelő az érték
            while (szam%2!=0) {
                Console.WriteLine("Nem megfelelő szám! Ismételje meg újra:");
                szam = Convert.ToInt32(Console.ReadLine());
            }
            // Visszajelzés, ha az érték megfelelt
            if (szam==0) {
                Console.WriteLine("Trükkös! A megadott szám megfelelő!");
            }
            else
            Console.WriteLine("A megadott szám megfelelő!");
        }       
    
        static void Feladat08()
        {
            //----------- 8.Írjunk programot, ami bekér a felhasználótól egy pozitív számot. Ha a felhasználó nem a feltételnek megfelelő számot ad meg, ismételjük meg a bekérést. Ha a szám megfelelő, írjuk ki a képernyőre a szám 5-tel vett osztási maradékát: -----------
            
            // Szám bekérése
            Console.WriteLine("Kérem adjon meg egy pozitív számot:");
            int szam = Convert.ToInt32(Console.ReadLine());

            //Ismétlés, amíg az érték nem megfelelő
            while (szam<0) {
                Console.WriteLine("Nem megfelelő szám! Ismételje meg újra:");
                szam = Convert.ToInt32(Console.ReadLine());
            }
            // A szám 5-tel vett osztási maradékának a kiírása
            Console.WriteLine($"{szam} / 5 maradéka --> {szam % 5}");
        }

        static void Feladat09()
        {
            //----------- 9.Kérjünk be két valós számot a felhasználótól, írjuk ki, hogy melyik a nagyobb! Ismételjük addig, amíg egyenlő számot nem írunk be: -----------

            //Számok bekérése
            int[] szamok = new int[2];
            Console.WriteLine("Kérem adjon meg két valós számot:");
            Console.WriteLine("Az első:");
            szamok[0]= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A második:");
            szamok[1] = Convert.ToInt32(Console.ReadLine());

            //A nagyobbik szám ismételt kiírása, amíg egyenlő nem lesz a két érték
            while (szamok[0] != szamok[1]) {
                Console.WriteLine($"A nagyobbik szám: {szamok.Max()}");
                Console.WriteLine("Kérem adjon meg két valós számot:");
                Console.WriteLine("Az első:");
                szamok[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A második:");
                szamok[1] = Convert.ToInt32(Console.ReadLine());
            }

            // Egyenlő értékek esetén
            Console.WriteLine("A két szám egyenlő!");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Feladat 1-2-3-4:");
            Console.WriteLine();
            Feladat1_2_3_4();

            Console.WriteLine();
            Console.WriteLine("Feladat 5:");
            Console.WriteLine();
            Feladat05();

            Console.WriteLine();
            Console.WriteLine("Feladat 6:");
            Console.WriteLine();
            Feladat06();

            Console.WriteLine();
            Console.WriteLine("Feladat 7:");
            Console.WriteLine();
            Feladat07();

            Console.WriteLine();
            Console.WriteLine("Feladat 8:");
            Console.WriteLine();
            Feladat08();

            Console.WriteLine();
            Console.WriteLine("Feladat 9:");
            Console.WriteLine();
            Feladat09();

            Console.ReadLine();
        }
    }
}
