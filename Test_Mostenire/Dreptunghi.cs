using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mostenire
{
    public class Dreptunghi : ElementeGeometrice
    {
        Linie _linie1 = new Linie();
        Linie _linie2 = new Linie();
        Linie _linie3 = new Linie();
        Linie _linie4 = new Linie();

        public Dreptunghi()
        {

        }
        public Dreptunghi(Linie linie1, Linie linie2, Linie linie3, Linie linie4)
        {
            this._linie1 = linie1;
            this._linie2 = linie2;
            this._linie3 = linie3;
            this._linie4 = linie4;

        }
        public Linie GetLinie1()
        {
            return _linie1;
        }
        public Linie GetLinie2()
        {
            return _linie2;
        }
        public Linie GetLinie3()
        {
            return _linie3;
        }
        public Linie GetLinie4()
        {
            return _linie4;
        }

        public override void Afisare()
        {
            Console.WriteLine("Latura1:  ");
            _linie1.Afisare();
            Console.WriteLine("Latura2:  ");
            _linie2.Afisare();
            Console.WriteLine("Latura3:  ");
            _linie3.Afisare();
            Console.WriteLine("Latura4:  ");
            _linie4.Afisare();


        }
    }
}
