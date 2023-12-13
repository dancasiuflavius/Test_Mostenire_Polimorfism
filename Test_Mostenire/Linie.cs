using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mostenire
{
    public class Linie : Figura
    {
        private Punct _punct1;
        private Punct _punct2;
      
        public Linie(Punct punct1, Punct punct2)
        {
            _punct1 = punct1;
            _punct2 = punct2;
        }
        public Punct GetPunct1()
        {
            return _punct1;
        }
        public Punct GetPunct2()
        {
            return _punct2;

        }

        public override void Afisare()
        {         
            Console.WriteLine(this);
        }
        public override void Translatare(int x, int y)
        {
            this._punct1.Translatare(x, y);
            this._punct2.Translatare(x, y);

        }
        public override Figura Duplicare()
        {
            return new Linie(this._punct1, this._punct2);
        }
        public override String ToString()
        {
            return "\nLinie :" + _punct1 + " " + _punct2 + "\n";
        }
    }
}
