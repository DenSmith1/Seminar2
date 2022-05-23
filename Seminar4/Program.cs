// 1. Выяснить являются ли три числа сторонами треугольника

// Console.Write("Введите 1 сторону треугольника: ");
// int Side1 = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите 2 сторону треугольника: ");
// int Side2 = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите 3 сторону треугольника: ");
// int Side3 = int.Parse(Console.ReadLine() ?? "0");

// if ((Side1+Side2) > Side3 && (Side1+Side3) > Side2 && (Side2+Side3) > Side1)
//     Console.WriteLine ("Являются сторонами треугольника");
// else
//     Console.WriteLine ("НЕ являются сторонами треугольника");


// 2. Перевести число в двоичное
// Console.Write("Введите число: ");
// int Number = int.Parse(Console.ReadLine() ?? "0");
// int Bit = Number % 2;
// int NewNumber = Bit;
// Number = Number / 2;
// int i = 1;
// while (Number > 0)
// {
//     Bit = Number % 2;
//     Number = Number / 2;
//     NewNumber = NewNumber + Bit * (int)Math.Pow(10,i);
//     i++;
// }
// Console.WriteLine(NewNumber);

// void FillArray(int[] array) 
// {
//     int tmp = 0;
//     int index = 0;
//     int length = array.Length;
//     while(index < length)
//     {
//         tmp = number % 2;
//         number = number /2;
//         array[index] = tmp;

//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while(position < count)
//     {
//         Console.Write(col[position]);
//         position++;
//     }
// }
// //Написать программу преобразования десятичного числа в двоичное
// Console.WriteLine("Number?");
// int number = int.Parse(Console.ReadLine());
// int tmpnumber = number;
// int tmp = 0;
// int count = 0;
// while(tmpnumber > 0)
//     {
//         tmp = tmpnumber % 2;
//         tmpnumber = tmpnumber /2;
//         count++;
//     }

// int[] array = new int[count];
// FillArray(array);
// PrintArray(array.Reverse().ToArray()); //Reverse array


// Console.WriteLine("Введите число");
// int a = int.Parse(Console.ReadLine());
// int b = 0;
// string result = " ";
// //int result = 0;

// while(a > 0)
// {
//     b = a % 2;
//     result = b + result;
//     a = a / 2;
// }
// Console.WriteLine(result);


// Показать числа Фибоначчи меньше заданного числа N
Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine() ?? "0");
int i1 = 0;
int i2 = 1;
int sum = 0;
Console.Write($"{i1}  {i2} ");
while (i1 + i2 < Number)
{
    sum = i1 + i2;
    i1 = i2;
    i2 = sum;
    Console.Write($" {sum} ");
}
