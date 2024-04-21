namespace DesignPatterns.ObserverDesignPattern;

public abstract class Observer
{
    /// <summary>
    /// Observer/Gözlemci Tasarım deseninde amaç bir abone listesi oluşturmak ve sınıfa abone olan gözlemcileri istenen olay oluştuğunda bilgilendirmektir.<br></br>
    /// <br></br>
    /// Buradaki örneğimizde bir öğrencinin okula gelmediğinde abone olan nesnelere bilgilendirme gönderilecektir. bilgilendirilecek sınıflar olarak Öğrenciye abone olan
    /// <see cref="FatherObserver"/>Baba, <see cref="MotherObserver"/>Anne ve <see cref="TeacherObserver"/>Öğretmenine derse gelmediği zaman bu metot aracılığı ile bilgi verilecektir.
    /// </summary>
    public abstract void SendInfo();
}