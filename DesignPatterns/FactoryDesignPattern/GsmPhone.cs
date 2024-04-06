namespace DesignPatterns.FactoryDesignPattern;

public class GsmPhone : ICommunication
{
    public bool ContactUs()
    {
        Console.WriteLine("Telefon numarasına SMS Gönderildi.");
        return true;
    }
}