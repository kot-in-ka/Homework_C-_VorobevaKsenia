// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Посмотрим на все четные числа от 1 до N");
Console.WriteLine("Ведите число N больше 1");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 1)
{
   int i = 2;
   while (i <= N)
   {
    Console.WriteLine(i);
    i = (i + 2);
   }
}
else
{
   Console.WriteLine("Ваше число меньше или равно 1");
}