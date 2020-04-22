using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class Vare
    {
     
        private string NewNavn;
        private int VareTilbage;
        private int Pris;

        public int pris
        {
            get { return Pris; }
            set { Pris = value; }
        }

        public int varetilbage
        {
            get { return VareTilbage; }
            set { VareTilbage = value; }
        }

        public string Navn
        {
            get { return NewNavn; }
            set { NewNavn = value; }
        }


        public Vare(string navn)
        {
            this.Navn = navn;
        }

        public Vare(string navn, int varetilbage, int pris)
        {
            this.Navn = navn;
            this.VareTilbage = varetilbage;
            this.Pris = pris;
        }

        public Vare(string navn, int pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }
    }
}
