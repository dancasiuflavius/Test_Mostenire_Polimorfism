using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mostenire
{
    public class Cerc : ElementeGeometrice
    {
        private Punct _punct = new Punct();
        private Linie _linie = new Linie();

        public Cerc(Punct punct, Linie linie)
        {
            this._punct = punct;
            this._linie = linie;
        }

        public Punct GetPunct()
        {
            return _punct;
        }
        public Linie GetLinie()
        {
            return _linie;
        }
        public override void Afisare()
        {
            Console.WriteLine("Cercul cu: ");
            Console.Write("Centrul de ");
            _punct.Afisare();
            Console.WriteLine("Raza:");
            _linie.Afisare();
            
        }
    }
}
