// 1. Показать натуральные числа от N до 1

void ShowNumbers(int Numbers)
{
    if (Numbers < 1) return;
    Console.Write(Numbers + " ");
    ShowNumbers(Numbers - 1);
}

ShowNumbers(15);


// 2. Показать натуральные числа от 1 до N

void ShowNumbers(int Numbers)
{
    if (Numbers < 1) return;
    ShowNumbers(Numbers - 1);
    Console.Write(Numbers + " ");
}

ShowNumbers(15);






















// void PrintNumber(int n)
// {
//     if(n<1)return;
//     PrintNumber(n-1);
//     Console.Write (n + "");
// }
// PrintNumber(10);

// Console.Clear();
// Console.WriteLine("Показать натуральные числа от N до 1, N задано");
// Console.Write("Введите число N: ");
// int NumberN = int.Parse(Console.ReadLine() ?? "0");

// int N = 1;
// PrintNaturalNumbers(N);

// void PrintNaturalNumbers (int N)
// {
//     if (N<=NumberN)
//     {
//         Console.Write($"{N} ");
//         N++;
//         PrintNaturalNumbers(N);
//     }
// }
