Auto auto = new Auto();
//vyfuk = 1
Auto.Vyfuk = 6;
// vyfuk = 6

Auto auto2 = new Auto();
// vyfuk = 6
Console.ReadLine();

internal class Auto
{
    public int Kolesa;
    public int Dvere = 4;
    public static int Vyfuk = 1;
}


