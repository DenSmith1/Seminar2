// Домашнее задание 1. Дни недели
Console.Write("Введите номер дня недели (1-7): ");
int weekday = int.Parse(Console.ReadLine());
while (weekday > 7 || weekday < 1)
{
    Console.Write("Вы ввели неверный номер недели. Повторите попытку: ");
    weekday = int.Parse(Console.ReadLine());
}
if (weekday == 6 || weekday == 7)
{
    Console.Write("Выходной день");
}
else
    Console.Write("Рабочий день");
