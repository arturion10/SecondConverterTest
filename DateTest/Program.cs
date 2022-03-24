Console.Write("Введите количество секунд для конвертации: ");
long second;
while(true)
{
    bool isSecond = long.TryParse(Console.ReadLine(), out second);
    if(isSecond)
    {
        break;
    }
    Console.WriteLine("Вы ввели неверные данные попробуйте еще раз");
}
Console.WriteLine($"Прошло суток: {second / 86400}\n" +
                  $"Прошло часов: {second % 86400 / 3600}\n" +
                  $"Прошло минут: {second % 3600 / 60}\n" +
                  $"Прошло секунд: {second % 60}\n");