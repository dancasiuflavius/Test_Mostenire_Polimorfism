using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mostenire
{
    public class Eticheta : ElementeGeometrice
    {
        Dreptunghi _dreptunghi = new Dreptunghi();
        String _text;

        public Eticheta(Dreptunghi dreptunghi, string text)
        {
            _dreptunghi = dreptunghi;
            _text = text;
        }
        public Dreptunghi GetDreptunghi()
        {
            return _dreptunghi;
        }
        public String GetEticheta()
        {
            return _text;
        }
        public override void Afisare()
        {
            _dreptunghi.Afisare();
            Console.WriteLine(_text);

        }
    }
}
