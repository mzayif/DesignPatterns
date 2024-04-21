using DesignPatterns.DependencyInjectionDesignPattern;
using DesignPatterns.FactoryDesignPattern;
using DesignPatterns.ObserverDesignPattern;
using DesignPatterns.SingletonDesignPattern;
using DesignPatterns.StrategyDesignPattern;

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

        Console.WriteLine("===============   Factory DesignPatterns  ==================");
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

        #region DependencyInjection Design Pattern
        Console.WriteLine("===============   DependencyInjection Design Pattern  ==================");
        var car = new Vehicle(new Car());
        car.Drive();
        var bus = new Vehicle(new Bus());
        bus.Drive();
        var motorCycle = new Vehicle(new Motorcycle());
        motorCycle.Drive();


        #endregion

        #region Strategy Design Pattern

        Console.WriteLine("===============   Strategy Design Pattern  ==================");
        var produce1 = new OpelCarProduce(new MassProduce());
        var produce2 = new OpelCarProduce(new PrivateProduce());
        var produce3 = new OpelCarProduce(new ProductionToOrder());

        #endregion

        #region Observer Design Pattern

        Console.WriteLine("===============   Observer Design Pattern  ==================");

        var student = new Student()
        {
            Name = "Ahmet",
            Surname = "Yılmaz",
            Address = "Test",
            Class = 5
        };

        student.AddObserver(new FatherObserver());
        student.AddObserver(new MotherObserver());
        student.AddObserver(new TeacherObserver());

   
        student.IsSkipSchool = true;

        #endregion


        Console.ReadLine();
    }
}
