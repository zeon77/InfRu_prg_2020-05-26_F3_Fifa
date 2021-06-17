﻿using System;
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

            //4. feladat
            Console.WriteLine($"4. feladat: A csapatok átlagos pontszáma: {csapatok.Average(x => x.Pontszám):0.00} pont");

            //5. feladat
            Csapat cs = csapatok.OrderBy(x => x.Változás).Last();
            Console.WriteLine($"5. feladat: A legtöbbet javító csapat:");
            Console.WriteLine($"\t Helyezés: {cs.Helyezés}");
            Console.WriteLine($"\t Csapat: {cs.Név}");
            Console.WriteLine($"\t Pontszám: {cs.Pontszám}");
        }
    }
}
