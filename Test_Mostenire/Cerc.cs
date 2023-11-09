using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mostenire
{ 
    public class Cerc : Figura
    {
        private Punct _punct;
        private Linie _linie;

        public Cerc(Punct punct, Linie linie)
        {
            this._punct = punct;
            this._linie = linie;
        }


        public override void Afisare()
        {
            Console.WriteLine(this);
        }
        public override void Translatare(int x, int y)
        {
            this._punct.Translatare(x, y);
            this._linie.Translatare(x, y);

        }
        public override Figura Duplicare()
        {
            return new Cerc(this._punct, this._linie);
        }
        public override String ToString()
        {
            return "Cercul de Raza: " + _linie + " " + "si centrul: " + _punct ;
        }
    }
}
