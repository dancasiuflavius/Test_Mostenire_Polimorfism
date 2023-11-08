using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mostenire
{
    public class Punct : ElementeGeometrice
    {
        private int _coordonataX;
        private int _coordonataY;


        public Punct()
        {

        }
        public Punct(int coordonataX, int coordonataY)
        {
            _coordonataX = coordonataX;
            _coordonataY = coordonataY;
        }

        public int GetX()
        {
            return _coordonataX;
        }
        
        public int GetY()
        {
            return _coordonataY;
        }
        
        public override void Afisare()
        {
            Console.WriteLine("Coordonate: " + GetX() + ' ' + GetY());
        }

    }
}
