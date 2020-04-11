using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Shared
{
    public class Artikal
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public decimal Cena { get; set; }
        public Artikal(string n, decimal d)
        {
            Naziv = n;
            Cena = d;
        }
        public Artikal() { }
    }
}
