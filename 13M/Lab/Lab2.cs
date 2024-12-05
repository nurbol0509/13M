using System;

class OnlineCourseSystem
{
    public static void Main()
    {
        int totalModules = 5;
        int completedModules = 5;
        double testScore = 85.0;

        string result = CheckResults(totalModules, completedModules, testScore);

        Console.WriteLine(result);
    }

    static string CheckResults(int totalModules, int completedModules, double testScore)
    {
        if (completedModules < totalModules)
        {
            return "Вы не завершили все модули. Завершите обучение для получения сертификата.";
        }
        else if (testScore >= 75.0)
        {
            return "Поздравляем! Вы успешно завершили курс и получили сертификат.";
        }
        else
        {
            return "Ваши результаты неудовлетворительны. Пересдайте тесты.";
        }
    }
}
