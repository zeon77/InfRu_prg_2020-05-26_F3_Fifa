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
        }
    }
}
