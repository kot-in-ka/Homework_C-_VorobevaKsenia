// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите любое число, что бы узнать его третью цифру ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

if (number > 99)
{
  while (number > 999)
  {
    number /= 10;
    Console.WriteLine(number);
  }
  Console.WriteLine("Третья цифра этого числа -> " + number%10);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}



// Console.Clear();
// Console.WriteLine("Введите любое число, что бы узнать его третью цифру ");
// int x = Convert.ToInt32(Console.ReadLine());

// int CreateNumber()
// {
//   x = (x/10)%10;
//   return x;
// }


// if (x>99 && x<1000)
// {
//   Console.WriteLine("Третья цифра этого числа -> " + x%10);
// }

// else
// {
//   Console.WriteLine("Третьей цифры нет");
// }