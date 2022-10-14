// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
Cube(x);

void Cube(int x)
{
    for (int i = 1; i <= x; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}");
        if (i != x)
        {
            Console.Write(", ");
        }
    }
}