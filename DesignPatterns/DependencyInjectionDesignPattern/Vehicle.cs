namespace DesignPatterns.DependencyInjectionDesignPattern;

public class Vehicle
{
    private readonly IVehicle _vehicle;

    public Vehicle(IVehicle vehicle)
    {
        _vehicle = vehicle;
    }
    
    /// <summary>
    /// Dependency Injection tasarımında amaç bağımlılıkları azaltmaktır. Ortak kullanılacak metotlar ve propertylerin tanımlandığı bir Interface
    /// veya Abstract Class kullanılarak, gelecek bütün sınıflarda ortak işlemlerin tek bir metot aracılığı ile yapılması amaçlanır.
    /// Kullanılacak sınıf Constructor aracılığı ile kullanılacak sınıf belirlenir. <br></br>
    /// <br></br>
    /// Buradaki örnekte <see cref="IVehicle"/> adında araçları kullanabilecek bir Interface tasarlanmıştır. Gene bu interface i kullanacak buradaki Drive metodu tasarlandı.
    /// <see cref="Vehicle"/> sınıfına verilen herhangi bir <see cref="IVehicle"/> tipinden implement edilen sınıf buradaki metot aracılığı ile kullanılacaktır.
    /// </summary>
    public void Drive()
    {
        _vehicle.SpeedUp();
        _vehicle.SignalRight();
        _vehicle.SignalLeft();
        _vehicle.SpeedDown();
    }
}