using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mostenire
{
    public class Dreptunghi : Figura
    {
        Linie _linie1 ;
        Linie _linie2 ;
        Linie _linie3 ;
        Linie _linie4 ;

        public Dreptunghi(Linie linie1, Linie linie2, Linie linie3, Linie linie4)
        {
            this._linie1 = linie1;
            this._linie2 = linie2;
            this._linie3 = linie3;
            this._linie4 = linie4;

        }

        public override void Afisare()
        {
            Console.WriteLine(this);
        }
        public override void Translatare(int x, int y)
        {
            this._linie1.Translatare(x, y);
            this._linie2.Translatare(x, y);
            this._linie3.Translatare(x, y);
            this._linie4.Translatare(x, y);

        }
        public override Figura Duplicare()
        {
            return new Dreptunghi(this._linie1, this._linie2, this._linie3, this._linie4);
        }
        public override String ToString()
        {
            return "Dreptunghiul : " + _linie1 + " " + _linie2 + " " + _linie3 + " " + _linie4;
        }
    }
}
