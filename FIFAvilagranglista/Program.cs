using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace FIFAvilagranglista
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            List<Csapat> csapatok = new List<Csapat>();
            foreach (var sor in File.ReadAllLines("fifa.txt", Encoding.UTF8).Skip(1))
                csapatok.Add(new Csapat(sor));

            //3.
            Console.WriteLine($"3. feladat: A világranglistán {csapatok.Count} csapat szerepel");

            //4.
            Console.WriteLine($"4. feladat: A csapatok átlagos pontszáma: {csapatok.Average(x => x.Pontszám):0.00} pont");

            //5.
            Csapat cs = csapatok.OrderBy(x => x.Változás).Last();
            Console.WriteLine($"5. feladat: A legtöbbet javító csapat:");
            Console.WriteLine($"\t Helyezés: {cs.Helyezés}");
            Console.WriteLine($"\t Csapat: {cs.Név}");
            Console.WriteLine($"\t Pontszám: {cs.Pontszám}");

            //6.
            bool MO = csapatok.Any(x => x.Név == "Magyarország");
            Console.WriteLine($"6. feladat: A csapatok között {(MO ? "van" : "nincs")} Magyarország.");

            //7. feladat
            Console.WriteLine($"7. feladat: Statisztika");
            csapatok
                .GroupBy(x => x.Változás)
                .Select(group => new { Változás = group.Key, CsapatokSzáma = group.Count() })
                .Where(x => x.CsapatokSzáma > 1)
                .ToList().ForEach(x => Console.WriteLine($"\t{x.Változás} helyet változott: {x.CsapatokSzáma} csapat"));
        }
    }
}
