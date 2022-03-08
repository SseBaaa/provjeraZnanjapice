using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebastian_Krnjus_PPZ2
{
    internal class Negazirana
    {

        String naziv, pakiranje, kolicina;
        double cijena;

        public Negazirana(string naziv, string pakiranje, string kolicina, double cijena)
        {
            this.naziv = naziv;
            this.pakiranje = pakiranje;
            this.kolicina = kolicina;
            this.cijena = cijena;
        }

        public override string ToString()
        {
            String ispis= "Naziv: " + this.Naziv + Environment.NewLine + "Pakiranje: " + this.pakiranje + Environment.NewLine + "Kolicina: "
                + this.kolicina + Environment.NewLine + "Cijena: " + this.cijena + " kn" + Environment.NewLine;
            return ispis;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Pakiranje { get => pakiranje; set => pakiranje = value; }
        public string Kolicina { get => kolicina; set => kolicina = value; }
        public double Cijena { get => cijena; set => cijena = value; }
    }
}
