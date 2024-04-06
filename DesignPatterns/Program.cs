using DesignPatterns.FactoryDesignPattern;

namespace DesignPatterns;

internal class Program
{
    static void Main(string[] args)
    {
        #region Singleton Design Patterns

        Console.WriteLine("Singleton class : Nesneden 2 tane farklı değişken üretip 1. nesneye değer verilmektedir. \r\n2 nesneye değer verilmemesine rağmen bilgiler yazdırıldığında aynı değerlere ulaşılmaktadır. ");
        var singleton = Singleton.NesneVer();
        singleton.X = 10;
        singleton.Y = 20;

        var singleton2 = Singleton.NesneVer();
        Console.WriteLine($"{singleton2.X} + {singleton2.Y} = {singleton2.X + singleton2.Y}");
        
        #endregion


        #region Factory DesignPatterns

        var creator = new CommunicationCreator();
        var communication = creator.FactoryMethod(CommunicationType.Address);
        communication.ContactUs();
        communication = creator.FactoryMethod(CommunicationType.GsmPhone);
        communication.ContactUs();
        communication = creator.FactoryMethod(CommunicationType.Phone);
        communication.ContactUs();
        communication = creator.FactoryMethod(CommunicationType.EMail);
        communication.ContactUs();

        #endregion



        Console.ReadLine();
    }
}
