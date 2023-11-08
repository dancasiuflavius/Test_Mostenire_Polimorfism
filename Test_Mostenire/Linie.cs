using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mostenire
{
    public class Linie : ElementeGeometrice
    {
        private Punct _punct1 = new Punct();
        private Punct _punct2 = new Punct();
        public Linie()
        {

        }
        public Linie(Punct punct1, Punct punct2)
        {
            this._punct1 = punct1;
            this._punct2 = punct2;
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
            Console.WriteLine("Linia cu coordonatele: " );
            _punct1.Afisare();
            _punct2.Afisare();
        }
    }
}
