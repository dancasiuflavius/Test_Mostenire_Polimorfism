using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mostenire
{
    public class Desen:IFigura
    {

        private List<IFigura> figuri;
        public Desen(List<IFigura> figures)
        {

            this.figuri = figures;
        }

        public void Afisare()
        {

            foreach (IFigura fig in figuri)
            {


                fig.Afisare();
            }
        }
        public  void Translatare(int x,int y)
        {

            foreach (IFigura fig in figuri)
            {


                fig.Translatare(x,y);
            }
        }

        public  IFigura Duplicare()
        {
            List<IFigura> figuriDup = new List<IFigura>();
            foreach (IFigura fig in figuri)
            {


               figuriDup.Add(fig.Duplicare());
            }

            return new Desen(figuriDup);
        }

    }
}
