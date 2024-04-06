namespace DesignPatterns.FactoryDesignPattern;

public class EMail : ICommunication
{
    public bool ContactUs()
    {
        Console.WriteLine("e-posta gönderildi.");
        return true;
    }
}