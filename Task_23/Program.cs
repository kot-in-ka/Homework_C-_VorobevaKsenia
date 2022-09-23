// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

void GetPrintPow(int number)
{
    int count = 1;
    Console.WriteLine("Таблица кубов");
    while (count <= number)
    {
         Console.WriteLine(count + "\t" + Math.Pow((count),3));
         count ++;
    }
}
GetPrintPow(GetNumber());