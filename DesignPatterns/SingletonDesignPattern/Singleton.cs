using System.Security.Cryptography.X509Certificates;

namespace DesignPatterns.SingletonDesignPattern;

public class Singleton
{
    // Bir sınıf singleton olabilmesi için default cont erişilmez (private) olmalı.
    // Böylece sınıfın üretilmesi kontrol altına lınabilir.
    private Singleton()
    {

    }

    private static Singleton _singleton;

    //static metodun içinde bu referansı kullanabilmemiz için static olması gerekiyor.
    //static metodun içinde sadece static metodlar kullanılabilir.
    public static Singleton NesneVer()
    {
        if (_singleton == null)
        {
            _singleton = new Singleton();
        }

        return _singleton;
    }

    public int X;
    public int Y;
}