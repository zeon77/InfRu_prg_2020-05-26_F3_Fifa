using System;

namespace FIFAvilagranglista
{
    class Csapat
    {
        public string Név { get; set; }
        public int Helyezés { get; set; }
        public int Változás { get; set; }
        public int Pontszám { get; set; }
        
        public Csapat(string Adatsor)
        {
            string[] s = Adatsor.Split(';');
            Név = s[0];
            Helyezés = int.Parse(s[1]);
            Változás = int.Parse(s[2]);
            Pontszám = int.Parse(s[3]);
        }
    }
}