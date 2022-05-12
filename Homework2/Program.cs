// Домашнее задание 2. Квадрат чисел

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number2*number2 == number1)
{
    Console.Write(number1+" Является квадратом числа "+number2);
}
else if (number1*number1 == number2)
{
    Console.Write(number2+" Является квадратом числа "+number1);
}
else
    Console.Write("Данные числа не являются квадратами друг друга");