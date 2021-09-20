using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifszerkezet
{
    class DiakBeker
    {
        public string Nev { get; set; }
        public int EletKor { get; set; }

        public DiakBeker(string nev, int eletkor)
        {
            this.Nev = nev;
            this.EletKor = eletkor;
        }

        public void AdatKiir()
        {
            Console.WriteLine($"Név: {this.Nev} és életkor: {this.EletKor}");
        }
    }
}
