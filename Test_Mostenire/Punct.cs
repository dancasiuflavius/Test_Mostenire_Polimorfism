using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Test_Mostenire
{
    public class Punct :IFigura
    {
        private int _x;
        private int _y;


        public Punct()
        {

        }
        public Punct(int x, int y)
        {
            _x = x;
            _y= y;
        }       

        public  void Afisare()
        {
            Console.WriteLine(this);          
        }
        public  void Translatare(int x, int y)
        {
            this._x += x;
            this._y += y;  
        }

        public  IFigura Duplicare()
        {
            return  new Punct(this._x, this._y);
        }
        public override String ToString()
        {
           
           return "(" + _x + "," + _y + ")";
        }

    }
}
