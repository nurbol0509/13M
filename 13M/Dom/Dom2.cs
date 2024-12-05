using System;
using System.Collections.Generic;

class BookingSystem
{
    static void Main()
    {
        var venues = new Dictionary<string, bool>
        {
            { "Зал 1", true },
            { "Зал 2", false }
        };

        string requestedVenue = "Зал 1";
        Console.WriteLine($"Запрос на площадку: {requestedVenue}");

        if (venues.ContainsKey(requestedVenue) && venues[requestedVenue])
        {
            Console.WriteLine("Площадка доступна. Стоимость: 5000 руб.");
            Console.WriteLine("Проверьте детали и подтвердите бронирование.");

            Console.WriteLine("Клиент подтверждает бронирование.");
            bool paymentSuccess = ProcessPayment();

            if (paymentSuccess)
            {
                Console.WriteLine("Бронирование подтверждено. Уведомления отправлены.");
            }
            else
            {
                Console.WriteLine("Платеж отклонен. Повторите попытку.");
            }
        }
        else
        {
            Console.WriteLine("Площадка недоступна. Предлагаем выбрать другую.");
        }
    }

    static bool ProcessPayment()
    {
        Console.WriteLine("Обработка платежа...");
        return true;
    }
}
