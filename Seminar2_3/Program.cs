// Найти количество цифр
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine() ?? "0");
int digits = 1;
while (Number > 9)
{
    Number = Number/10;
    digits ++;
}
Console.WriteLine("Количество цифр: "+digits);