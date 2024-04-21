namespace DesignPatterns.ObserverDesignPattern;

public class FatherObserver : Observer
{
    public override void SendInfo()
    {
        Console.WriteLine("Öğrencinin kaçtığından babasının haberi oldu.");
    }
}