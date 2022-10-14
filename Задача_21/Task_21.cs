// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите X координаты точки А: ");
int ax = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y координаты точки А: ");
int ay = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Z координаты точки А: ");
int az = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите X координаты точки B: ");
int bx = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y координаты точки B: ");
int by = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Z координаты точки B: ");
int bz = int.Parse(Console.ReadLine()!);

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

    return result;
}

Console.WriteLine($"Длина отрезка AB = {Distance(ax, ay, az, bx, by, bz):f2}");