//  Программа замену элементов массива на противоположные

void PrintArray (int[]array)
{
    int count = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.Write("Введите размер массива: ");

int Number = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[Number];

for (int i = 0; i < Number; i++)
    arr[i] = new Random().Next(-100, 100);


PrintArray (arr);
Console.WriteLine ();

for (int i = 0; i < arr.Length; i++)
    arr [i] = -arr[i];

PrintArray (arr);

