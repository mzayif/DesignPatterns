namespace DesignPatterns.ObserverDesignPattern;

public class MotherObserver : Observer
{
    public override void SendInfo()
    {
        Console.WriteLine("Öğrencinin kaçtığından anasının haberi oldu.");
    }
}