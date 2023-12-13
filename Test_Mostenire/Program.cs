using Test_Mostenire;


public class Program
{
    private static void Main(string[] args)
    {


        IFigura figura = new Punct(1, 2);
       


        figura.Translatare(2, 4);


        IFigura f2=figura.Duplicare();


        f2.Afisare();

        Console.WriteLine("====================================");

        Punct punct1 = new Punct(1, 1);
        Punct punct2 = new Punct(3, 3);

        Linie figura3 = new Linie(punct1, punct2);

        //figura3.Afisare();
        //figura3.Translatare(1, 0);
        //figura3.Afisare();
        //Figura f4 = figura3.Duplicare();
        //f4.Afisare();


      

        IFigura figura4 = new Cerc(punct1, figura3);
       

        Punct A = new Punct(1, 1);
        Punct B = new Punct(3, 1);
        Punct C = new Punct(1, 4);
        Punct D = new Punct(3, 4);

        Linie linie1 = new Linie(A.Duplicare() as Punct, B);
        Linie linie2 = new Linie(B.Duplicare() as Punct, C);
        Linie linie3 = new Linie(C.Duplicare() as Punct, D);
        Linie linie4 = new Linie(D.Duplicare() as Punct, A);


        IFigura Figura5 = new Dreptunghi(linie1, linie2, linie3, linie4);
      




        List<IFigura> list = new List<IFigura>();

        list.Add(Figura5);
        list.Add(figura4);


        Desen desen = new Desen(list);

        desen.Afisare();



       
    }
}