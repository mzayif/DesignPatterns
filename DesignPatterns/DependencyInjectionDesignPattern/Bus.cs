namespace DesignPatterns.DependencyInjectionDesignPattern;

public class Bus : IVehicle
{
    public void SpeedUp()
    {
        Console.WriteLine("Otobüsün gazına basıldır. Saatte 80 KM hızla gidiliyor");
    }

    public void SpeedDown()
    {
        Console.WriteLine("Otobüsün frenine basıldır. Otobüs Durdu");
        Console.WriteLine("=======================================");
    }
}