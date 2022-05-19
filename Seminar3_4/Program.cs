// Найдите разницу между максимальным и минимальным элементом

Console.Write("Введите размер массива: ");

int Number = int.Parse(Console.ReadLine() ?? "0");
double[] arr = new double[Number];

for (int i = 0; i < Number; i++)
{
    arr[i] = new Random().NextDouble() * 10;
    arr[i] = Math.Round(arr[i],2);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine("");

int min = 0;
int max = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < arr[min]) min = i;
    else if (arr[i] > arr[max]) max = i;

}

Console.WriteLine($"Разница между {arr[max]} и {arr[min]} = {arr[max] - arr[min]}");