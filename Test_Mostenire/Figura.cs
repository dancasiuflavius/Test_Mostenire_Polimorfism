using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mostenire
{
    public class Figura
    {



        public  virtual void Afisare() 
        {
            Console.WriteLine("Eu sunt o figura");
        
        }
        public virtual void Translatare(int x, int y)
        {
            Console.WriteLine($"Eu sunt translatare {x} {y}");
        }
        public virtual Figura Duplicare ()
        {
            Console.WriteLine($"Eu sunt duplicare ");
            return null;
        }
    
    }
}
