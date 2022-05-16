// Произведение чисел
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
int Result = 1;
while (i <= Number)
{
    Result = Result*i;
    i++;
}
Console.WriteLine($"Произведение чисел от 1 до {Number} = {Result}");