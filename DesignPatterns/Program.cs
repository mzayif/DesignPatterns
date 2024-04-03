namespace DesignPatterns;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Singleton class : Nesneden 2 tane farklı değişken üretip 1. nesneye değer verilmektedir. \r\n2 nesneye değer verilmemesine rağmen bilgiler yazdırıldığında aynı değerlere ulaşılmaktadır. ");
        var singleton = Singleton.NesneVer();
        singleton.X = 10;
        singleton.Y = 20;

        var singleton2 = Singleton.NesneVer();
        Console.WriteLine($"{singleton2.X} + {singleton2.Y} = {singleton2.X + singleton2.Y}");


        Console.ReadLine();
    }
}
