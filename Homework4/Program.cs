// Домашнее задание 4. Расстояние между точек в пространстве 2D/3D

Console.WriteLine("Введите координаты точки А");                    // Вводими координаты точки А
Console.Write("X: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Y: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Z (если пространство двухмерное, то введите 0): ");  // Если плоскость двухмерная, то координаты Z = 0 для А и B
int zA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");                    // Вводими координаты точки B
Console.Write("X: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Y: ");
int yB = int.Parse(Console.ReadLine());
Console.Write("Z (если пространство двухмерное, то введите 0): ");  // Если плоскость двухмерная, то координаты Z = 0 для А и B
int zB = int.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow((xB-xA),2)+Math.Pow((yB-yA),2)+Math.Pow((zB-zA),2));
Console.WriteLine("Расстояние между точками = "+distance); 