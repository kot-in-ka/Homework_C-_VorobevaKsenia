// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите любое число, что бы узнать его третью цифру ");
int x = Convert.ToInt32(Console.ReadLine());

int CreateNumber()
{
  x = (x/10)%10;
  return 1;
  
}


if (x>99 && x<1000)
{
  Console.WriteLine("Третья цифра этого числа -> " + x%10);
}

else
{
  Console.WriteLine("Третьей цифры нет");
}

// string x = Console.ReadLine();
// if (x.Length > 2)
// {
//   Console.WriteLine("Третья цифра этого числа -> " + x[2]);
// }
// else 
// {
//   Console.WriteLine("Третьей цифры нет");
// }