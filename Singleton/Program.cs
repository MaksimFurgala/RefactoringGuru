// Клиентский код.
Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}

public sealed class Singleton
{
    // Конструктор Одиночки всегда должен быть скрытым, чтобы предотвратить
    // создание объекта через оператор new.
    private Singleton() { }

    // Объект одиночки храниться в статичном поле класса. Существует
    // несколько способов инициализировать это поле, и все они имеют разные
    // достоинства и недостатки. В этом примере мы рассмотрим простейший из
    // них, недостатком которого является полная неспособность правильно
    // работать в многопоточной среде.
    private static Singleton _instance;

    // Это статический метод, управляющий доступом к экземпляру одиночки.
    // При первом запуске, он создаёт экземпляр одиночки и помещает его в
    // статическое поле. При последующих запусках, он возвращает клиенту
    // объект, хранящийся в статическом поле.
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }
    
    // Наконец, любой одиночка должен содержать некоторую бизнес-логику,
    // которая может быть выполнена на его экземпляре.
    public void someBusinessLogic()
    {
        // ...
    }
}