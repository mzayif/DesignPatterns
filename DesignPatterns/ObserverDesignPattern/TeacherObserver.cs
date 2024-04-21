namespace DesignPatterns.ObserverDesignPattern;

public class TeacherObserver : Observer
{
    public override void SendInfo()
    {
        Console.WriteLine("Öğrencinin kaçtığından öğretmenin haberi oldu.");
    }
}