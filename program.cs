using System;
class figura1
{
    public struct Circulo1
    {
    private int  x,y;
    private float diametro1;
    public Circulo1(int a, int b, float Diametro1)
    {
    x = a;
    y = b;
    diametro1 = Diametro1
    }
}

public struct Elipse1
{
}
public void teste1()
{
    Circulo1 c_um = new Circulo1(0,0,10);
    Console.WriteLine("Estrutura do tipo aninhada");
        
}

}
class CsharpApp
{
    static void Main()
    {
        figura1 fig_um = figura1();
        fig_um.teste1();
        Console.ReadLine();
        }
    }



