namespace DesignPatterns.FactoryDesignPattern;

public class Address : ICommunication
{
    public bool ContactUs()
    {
        Console.WriteLine("Adrese mektup gönderildi.");
        return true;
    }
}