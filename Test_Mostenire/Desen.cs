using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mostenire
{
    public class Desen:Figura
    {

        private List<Figura> figuri;
        public Desen(List<Figura> figures)
        {

            this.figuri = figures;
        }

        public override void Afisare()
        {
            
             foreach(Figura fig in figuri)
            {


                fig.Afisare();
            }
        }
        public override void Translatare(int x,int y)
        {

            foreach (Figura fig in figuri)
            {


                fig.Translatare(x,y);
            }
        }

        public override Figura Duplicare()
        {
            List<Figura> figuriDup = new List<Figura>();
            foreach (Figura fig in figuri)
            {


               figuriDup.Add(fig.Duplicare());
            }

            return new Desen(figuriDup);
        }

    }
}
