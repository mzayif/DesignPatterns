// ReSharper disable CommentTypo
namespace DesignPatterns.FactoryDesignPattern;

public class CommunicationCreator
{
    /// <summary>
    /// Factory design Pattern de amaç bir İnterface veya Abstrac class üzerinden bütün ortak işlemleri karşılayabilecek metotlar oluşturulur.
    /// Bu örneğimizde <see cref="ICommunication"/> interface i oluşturulmuş ve bu sınıfta  bulunan <see cref="ICommunication.ContactUs"/> metodu kullanılması amaçlanmıştır.
    /// Bu metot <see cref="CommunicationType"/> iletişim tipine göre işlem yapılması amaçlanmıştır.
    /// Burada belirtilen iletişim tipine uygun olan sınıf oluşturularak geri döndürülür. ve o sınıftaki <see cref="ICommunication.ContactUs"/>  metodu aracılığı ile türe uygun olarak işlem yapılması sağlanır.
    /// </summary>
    /// <param name="communicationType"></param>
    /// <returns></returns>
    public ICommunication FactoryMethod(CommunicationType communicationType)
    {
        ICommunication communication = null;
        switch (communicationType)
        {
            case CommunicationType.Address:
                communication = new Address();
                break;
            case CommunicationType.GsmPhone:
                communication = new GsmPhone();
                break;
            case CommunicationType.Phone:
                communication = new Phone();
                break;
            case CommunicationType.EMail:
                communication = new EMail();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(communicationType), communicationType, null);
        }

        return communication;
    }
}