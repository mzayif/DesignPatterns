
namespace DesignPatterns.DependencyInjectionDesignPattern;

public class Car : IVehicle
{
    public void SpeedUp()
    {
        Console.WriteLine("Arabanın gazına basıldır. Saatte 100 KM hızla gidiliyor");
    }

    public void SpeedDown()
    {
        Console.WriteLine("Arabanın frenine basıldır. Araba Durdu");
        Console.WriteLine("=======================================");
    }
}