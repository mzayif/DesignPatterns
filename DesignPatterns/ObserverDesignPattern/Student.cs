namespace DesignPatterns.ObserverDesignPattern;

public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public int Class { get; set; }

    bool isSkipSchool;

    /// <summary>
    /// Bu property Observer tasarım desenini uygulayacağımız ve değişikliğini kontrol edeceğimiz özelliktir.
    /// o yüzden get ve set metotları manüple edilerek set durumunda true yani, öğrenci okula gelmedi şeklinde güncellendiğinde
    /// <see cref="Notify"/>> metodu tetiklenir.
    /// </summary>
    public bool IsSkipSchool
    {
        get => isSkipSchool;
        set
        {
            if (value)
                Notify();

            isSkipSchool = value;
        }
    }

    // Öğrenci nesnesi abone olan gözlemcileri bu listede tutacaktır.
    private readonly List<Observer> _observers = new();


    /// <summary>
    /// Gözlemci ekle
    /// </summary>
    /// <param name="observer"></param>
    public void AddObserver(Observer observer)
    {
        _observers.Add(observer);
    }

    /// <summary>
    /// Gözlemci çıkar
    /// </summary>
    /// <param name="observer"></param>
    public void RemoveObserver(Observer observer)
    {
        _observers.Remove(observer);
    }

    /// <summary>
    /// Herhangi bir güncelleme olursa ilgili gözlemcilere haber verecek metodumuzdur.
    /// </summary>
    public void Notify()
    {
        _observers.ForEach(g => g.SendInfo());
    }
}