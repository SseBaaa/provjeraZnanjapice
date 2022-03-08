using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebastian_Krnjus_PPZ2
{
    internal class Alkoholna
    {

        String naziv, pakiranje, kolicina;
        double cijena, alkohol;

        public Alkoholna(string naziv, string pakiranje, string kolicina, double cijena, double alkohol)
        {
            this.naziv = naziv;
            this.pakiranje = pakiranje;
            this.kolicina = kolicina;
            this.cijena = cijena;
            this.alkohol = alkohol;
        }
        public override string ToString()
        {
            String ispis = "Naziv: " + this.naziv + Environment.NewLine + "Pakiranje: " + this.pakiranje + Environment.NewLine + "Količina: "
                + this.kolicina + Environment.NewLine + "Cijena: " + this.cijena + " kn" + Environment.NewLine + "Posto alkohola: " + this.alkohol + Environment.NewLine;
            return ispis;
        }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Pakiranje { get => pakiranje; set => pakiranje = value; }
        public string Kolicina { get => kolicina; set => kolicina = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public double Alkohol { get => alkohol; set => alkohol = value; }
    }
}
