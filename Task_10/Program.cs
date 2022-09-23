//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int x = int.Parse(Console.ReadLine());
void ChoisNumber()
{
  if ((x < 100) || (x > 999))
  {
    Console.WriteLine("Это не трёхзначное число");
  }
  else
  Console.WriteLine("Вторая цифра вашего числа = " + ((x/10)%10));
}
ChoisNumber();



// string x = Console.ReadLine();
// if (x.Length == 3)
// {
//   Console.WriteLine("Вторая цифра этого числа -> " + x[1]);  
// }
// else Console.WriteLine("Это не трехзначное число");