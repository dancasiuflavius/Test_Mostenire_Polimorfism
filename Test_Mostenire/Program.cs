using System.Net.Http.Headers;
using Test_Mostenire;

public class Program
{
    private static void Main(string[] args)
    {
        Punct punct1 = new Punct(2,3);
        Punct punct2 = new Punct(5, 6);
        punct1.Afisare();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Linie linie = new Linie(punct1, punct2);
        linie.Afisare();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Cerc cerc = new Cerc(punct1, linie);
        cerc.Afisare();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Punct punctA = new Punct(1, 1);
        Punct punctB = new Punct(1, 3);
        Punct punctC = new Punct(4, 3);
        Punct punctD = new Punct(4, 1);

        Linie linie1 = new Linie(punctA, punctB);
        Linie linie2 = new Linie(punctB, punctC);
        Linie linie3 = new Linie(punctC, punctD);
        Linie linie4 = new Linie(punctD, punctA);

        Dreptunghi dreptunghi = new Dreptunghi(linie1, linie2, linie3, linie4);
        dreptunghi.Afisare();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        String text = "text";
        Eticheta eticheta = new Eticheta(dreptunghi, text);
        eticheta.Afisare(); 

    }
}