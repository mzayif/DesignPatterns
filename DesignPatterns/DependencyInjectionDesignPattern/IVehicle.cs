namespace DesignPatterns.DependencyInjectionDesignPattern;

public interface IVehicle
{
    void SpeedUp();
    void SpeedDown();

    void SignalRight()
    {
        Console.WriteLine("Sağa sinyal verildi.");
    }
    void SignalLeft()
    {
        Console.WriteLine("Sola sinyal verildi.");
    }
}