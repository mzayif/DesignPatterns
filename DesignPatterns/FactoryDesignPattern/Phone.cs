namespace DesignPatterns.FactoryDesignPattern;

public class Phone : ICommunication
{
    public bool ContactUs()
    {
        Console.WriteLine("Telefon üzerinden otomatik arama yapıldı.");
        return true;
    }
}