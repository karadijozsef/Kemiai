using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemiai
{
    internal class Felfedezes
    {
        public Felfedezes(string sor)
        {
            string[] sorelem = sor.Split(';');
            this.Ev = sorelem[0];
            this.Nev = sorelem[1];
            this.Vegyjel = sorelem[2];
            this.Rendszam = Convert.ToInt32(sorelem[3]);
            this.Felfedezo = sorelem[4];
        }
        public string Ev { get; set; }
        public string Nev { get; set; }
        public string Vegyjel { get; set; }
        public int Rendszam { get; set; }
        public string Felfedezo { get; set; }
    }
}
