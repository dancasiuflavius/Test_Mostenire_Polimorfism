using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mostenire
{
    public class Eticheta : Dreptunghi
    {
        String _text;

        public Eticheta(Linie a,Linie b,Linie c ,Linie d, string text):base(a,b,c,d)
        {
            
            _text = text;
        }
        public override void Afisare()
        {
            Console.WriteLine(this);
        }

        public override String ToString()
        {
            return "Eticheta : " + base.ToString() + "\n" + _text;
        }
    }
}
