// Создать массив из 8 элементов
Console.WriteLine("Задать массив из 8 элементов и вывести их на экран");
Console.Write("Введите размер массива: ");

int Number = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[Number];

for (int i = 0; i < Number; i++)
    array[i] = new Random().Next(0, 100);

int count = 1;
foreach (int k in array)
{
    Console.WriteLine($"{count} элемент массива - {k}");
    count++;
}

