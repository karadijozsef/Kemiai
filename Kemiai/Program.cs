using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kemiai
{
    internal class Program
    {
        static List<Felfedezes> adat = new List<Felfedezes>();

        static void Main(string[] args)
        {
            //2.feladat
            StreamReader Olvas = new StreamReader("felfedezesek.csv", Encoding.Default);
            string Fejlec = Olvas.ReadLine();
            while (!Olvas.EndOfStream)
            {
                adat.Add(new Felfedezes(Olvas.ReadLine()));
            }
            Olvas.Close();

            //3.feladat
            Console.WriteLine($"2.feladat: Elemek száma: {adat.Count}");

            //4.feladat
            Console.WriteLine($"4.feladat: Felfedezések száma az Ókorban: {adat.Count(x=>x.Ev=="Ókor")}");

            //5.feladat


            //6.feladat
            
            bool vanevegyjel = false;
            for (int i = 0; i < adat.Count; i++)
            {
                Console.WriteLine("6.feladat: Keresés");
                if (adat[i].Vegyjel.ToUpper()==vegyjel.ToUpper())
                {
                    vanevegyjel = true;
                    Console.WriteLine($"\tAz elem vegyjele: {adat[i].Vegyjel}");
                    Console.WriteLine($"\tAz elem neve: {adat[i].Nev}");
                    Console.WriteLine($"\tAz elem Rendszáma: {adat[i].Rendszam}");
                    Console.WriteLine($"\tFelfedezés éve: {adat[i].Ev}");
                    Console.WriteLine($"\tAz elem Felfedezője: {adat[i].Felfedezo}");
                }
            }
            if (vanevegyjel==false)
            {
                Console.WriteLine("Nincs ilyen elem az adatbázisban!");
            }
            

            //7.feladat
            int LeghosszabbEv = 0;
            for (int i = 0; i < adat.Count; i++)
            {
                if (adat[i].Ev != "Ókor")
                {
                    if (Convert.ToInt32(adat[i+1].Ev) - Convert.ToInt32(adat[i].Ev)>LeghosszabbEv)
                    {
                        LeghosszabbEv = Convert.ToInt32(adat[i + 1].Ev) - Convert.ToInt32(adat[i].Ev);
                    }
                }
            }
            Console.WriteLine($"7.feladat: {LeghosszabbEv} év volt a leghosszabb időszak a két elem felfedezése között.");

            //8.feladat
            Console.WriteLine("8.feladat: Statisztika");
            adat.GroupBy(j => j.Ev).Where(g => g.Count() > 3 && g.Key != "Ókor").ToList().ForEach(a => Console.WriteLine($"\t{a.Key}: {a.Count()} db"));


            Console.WriteLine("\nProgram vége!");
            Console.ReadKey();
        }
    }
}
