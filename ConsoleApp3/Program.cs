//ЗАДАНИЕ 2 Создать класс SmsMessage, отвечающий за отправку sms-сообщений. У класса должно быть
//два свойства: MessageText — текст сообщения и Price — стоимость сообщения. Сообщения
//длиной менее 65 символов стоят 1.5 рубля, сообщения длиной более 65 символов облагаются
//налогом, по 50 копеек за каждый дополнительный символ. Максимальная длина сообщения
//250 символов. Если длина сообщение больше 250 символов, то оно обрезается до корректной
//длины.


//class SmsMessage
//{
//    private string messageText;
//    private double price;

//    public string MessageText
//    {
//        get { return messageText; }
//        set { messageText = value.Length > 250 ? value.Substring(0, 250) : value; }
//    }

//    public double Price
//    {
//        get { return CalculatePrice(); }
//    }

//    public SmsMessage(string messageText)
//    {
//        MessageText = messageText;
//    }

//    private double CalculatePrice()
//    {
//        if (messageText.Length <= 65)
//        {
//            return 1.5;
//        }
//        else
//        {
//            int additionalCharacters = messageText.Length - 65;
//            double additionalCost = additionalCharacters * 0.5;
//            return 1.5 + additionalCost;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string text1 = "а"; // менее 65 символов
//        string text2 = "аааааааааааааааааааааааааа"; // более 65 символов

//        SmsMessage message1 = new SmsMessage(text1);
//        SmsMessage message2 = new SmsMessage(text2);

//        Console.WriteLine($"Текст сообщения 1: {message1.MessageText}, Стоимость: {message1.Price} рубля");
//        Console.WriteLine($"Текст сообщения 2: {message2.MessageText}, Стоимость: {message2.Price} рубля");
//    }
//}










//ЗАДАНИЕ 3 Создать класс SQLCommand со свойством CommandText, которое предоставляет доступ к
//тексту SQL-запросов. Предусмотреть автоматический перевод операторов языка SQL в верхний
//регистр при установке значения свойства CommandText.




/*
class SQLCommand
{
    private string commandText;

    public string CommandText
    {
        get { return commandText; }
        set { commandText = value.ToUpper(); }
    }

    public SQLCommand(string commandText)
    {
        CommandText = commandText;
    }
}

class Program
{
    static void Main()
    {
        string sqlQuery = "select * from users where age > 18"; 
        SQLCommand command = new SQLCommand(sqlQuery);

        Console.WriteLine($"Текст SQL-запроса: {command.CommandText}");
    }
}
*/







// ЗАДАНИЕ 6 Написать класс, позволяющий генерировать набор случайных чисел заданной длины. Класс
//должен предоставлять возможность получить значения дисперсии, среднеквадратического
//отклонения и медианы. В целях экономии ресурсов предусмотреть кэширование характеристик
//последовательности.

/*
class SQLCommand
{
    private string commandText;

    public string CommandText
    {
        get { return commandText; }
        set { commandText = value.ToUpper(); }
    }

    public SQLCommand(string commandText)
    {
        CommandText = commandText;
    }
}

class Program
{
    static void Main()
    {
        string query = "select * from customers where country = 'usa';";
        SQLCommand sqlCommand = new SQLCommand(query);

        Console.WriteLine($"SQL Query: {sqlCommand.CommandText}");
    }
}
*/