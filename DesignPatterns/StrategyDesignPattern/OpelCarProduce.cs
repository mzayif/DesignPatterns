namespace DesignPatterns.StrategyDesignPattern;

public class OpelCarProduce
{
    /// <summary>
    /// Strateji Tasarım Deseninde amaç Strateji veya Tipe göre yapılacak işlemi Bir Interface veya bir Abstract class kullanarak bütün tiplerde tek bir metod ile çalıştırılması amaçlanmaktadır.<br></br>
    /// <br></br>
    /// Örneğimizde <see cref="Opel"/> tipinde bir araç üretilmektedir. Ancak üretimde <see cref="MassProduce"/> Seri Üretim,
    /// <see cref="PrivateProduce"/> Özel Üretim, <see cref="ProductionToOrder"/> Sipariş üzerine üretim şeklinde 3 farklı üretim yöntemi bulunmaktadır. <br></br>
    /// <see cref="IStrategy"/> tipinden türetilmiş bu sınıfların hepsi <see cref="IStrategy.Produce"/> metodunu implement etmek ve Üretim yöntemine göre işlem yapmak zorundadır.<br></br>
    /// ve bütün bu işlemleri yapacak ve verilen tipe göre araç üretecek <see cref="OpelCarProduce"/> tipinde bu sınıf oluşturulmuştur.
    /// </summary>
    /// <param name="strategy"></param>
    public OpelCarProduce(IStrategy strategy)
    {
        strategy.Produce();
    }
}