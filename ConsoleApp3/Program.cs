using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> szamok = new List<double>();

            List<int> paratlanszamok = new List<int>();

            StreamReader beolv = new StreamReader("szamok.txt");

            Console.WriteLine($"A \"szamok.txt\" file feldolgozása: ");

            int szam = 0;

            double atlag = 0;

            double osszeg = 0;

            int paros = 0;

            //sorok szama

            while (!beolv.EndOfStream)
            {
                szamok.Add(Convert.ToDouble(beolv.ReadLine()));

                szam++;
            }

            //osszeg

            //int fasz = szamok.Sum(Convert.ToInt32);

            for (int i = 0; i < szamok.Count; i++)
            {
                osszeg = osszeg + szamok[i];
            }

            //atlag

            atlag = osszeg / szam;

            //paros v paratlan

            for (int i = 0; i < szam; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    paros++;
                }

                else
                {
                    paratlanszamok.Add(Convert.ToInt32(szamok[i]));
                }

            }

            //40 felett

            StreamWriter kiir = new StreamWriter("szamki.txt");

            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i] > 40)
                {
                    kiir.WriteLine(szamok[i]);
                }                
            }

            kiir.Close();



            Console.WriteLine($"Ennyi sor található a fileban: {szam}.");

            Console.WriteLine($"A számok összege: {osszeg}.");

            Console.WriteLine($"A számok átlaga: {atlag}.");

            Console.WriteLine($"Ennyi páros szám van: {paros}.");

            beolv.Close();

            Console.ReadKey();
        }
    }
}
