// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputNumber(string A)
{
    Console.Write($"Введите {A}: "); 
    return Convert.ToInt32(Console.ReadLine()); 
}

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
}

Console.WriteLine("Расстояние между точками в 3D пространстве: " + GetDistance(InputNumber("x1"),InputNumber("y1"),InputNumber("z1"),InputNumber("x2"),InputNumber("y2"),InputNumber("z2")));